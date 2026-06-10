<div align="center">

# Sakany
### Real Estate Rental Platform

A full-stack property rental management system built with ASP.NET Core 8 MVC.  
Connects property owners, tenants, and admins through a unified, role-based platform.

---

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=dotnet)
![EF Core](https://img.shields.io/badge/EF%20Core-8.0-512BD4?style=flat-square)
![SQL Server](https://img.shields.io/badge/SQL%20Server-latest-CC2927?style=flat-square&logo=microsoftsqlserver)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5-7952B3?style=flat-square&logo=bootstrap)

</div>

---

## Overview

Sakany is a multi-role web application that streamlines the property rental lifecycle — from listing and discovery to contracts and payments. Owners post properties, tenants submit rental requests, and admins oversee the entire platform, all within a single cohesive system.

---

## Features

| Module | Description |
|---|---|
| **Properties** | Create and manage listings with images, amenities, filtering, and pagination |
| **Rental Requests** | Full request lifecycle — Pending → Approved / Rejected |
| **Contracts** | Auto-generated PDF contracts emailed to both parties on approval |
| **Messaging** | Property-scoped direct messaging between users |
| **Reviews** | Tenant ratings available after an approved rental |
| **Notifications** | Real-time in-app alerts with live navbar badge |
| **Wishlist** | Save and manage favorite properties |
| **Reports** | Flag problematic listings for admin review |
| **Dashboard** | Platform-wide statistics and activity overview (Admin) |

---

## Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core MVC (.NET 8) |
| ORM | Entity Framework Core 8 |
| Database | SQL Server |
| PDF Generation | QuestPDF 2026.5.0 |
| Email | MailKit / MimeKit 4.16.0 |
| Password Hashing | PBKDF2-SHA256 (custom, 100k iterations) |
| Frontend | Razor Views + Bootstrap 5 |
| Validation | jQuery Validation Unobtrusive |

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- SQL Server (local or remote)
- Visual Studio 2022+ or VS Code *(optional)*

### Installation

```bash
# Clone the repository
git clone <repo-url>
cd Sakany

# Configure your connection string in appsettings.json

# Apply migrations — seeds 1,000 sample properties automatically
dotnet ef database update

# Start the application
dotnet run
```

The application will be available at `https://localhost:7xxx`.  
Check `Properties/launchSettings.json` for the exact port.

### Seed Accounts

| Email | Password | Role |
|---|---|---|
| `ahmed@example.com` | `hashed_pass` | Owner |
| `admin@example.com` | `hashed_pass` | Owner |

> No Admin or Tenant accounts are seeded by default. Create an Admin account directly in the database, then use the User Management panel to assign roles.

---

## Configuration

```json
// appsettings.json
{
  "ActiveConnection": "DefaultConnection",
  "ConnectionStrings": {
    "DefaultConnection": "Server=...;Database=SakanyDb;Trusted_Connection=True;"
  },
  "EmailSettings": {
    "Host": "smtp.example.com",
    "Port": "587",
    "Username": "your@email.com",
    "Password": "your_password",
    "FromName": "Sakany"
  }
}
```

Multiple connection strings are supported. Switch environments by changing the `ActiveConnection` key only.

---

## Project Structure

```
Sakany/
├── Controllers/        # Request handling and business logic per module
├── Models/             # EF Core entity definitions
├── Services/
│   ├── EmailService.cs     # SMTP email with PDF attachment (MailKit)
│   ├── PdfService.cs       # Contract PDF generation (QuestPDF)
│   └── PasswordHasher.cs   # PBKDF2-SHA256 hashing utility
├── Data/
│   └── SakanyDbContext.cs  # EF Core context, constraints, and seed data
├── Migrations/         # EF Core migration history
├── Views/              # Razor views organized by controller
└── wwwroot/
    └── uploads/properties/ # Uploaded property images
```

---

## User Roles & Access Control

Access control is enforced via server-side session on every action — no ASP.NET Identity middleware is used.

| Role | Landing Page | Capabilities |
|---|---|---|
| **Admin** | `/Dashboard` | Full platform access — users, properties, contracts, reports, amenities |
| **Owner** | `/Property` | Manage own listings; review and approve/reject incoming rental requests |
| **Tenant** | `/Home` | Browse properties; submit requests; leave reviews; messaging; wishlist |

Registration is restricted to the Tenant role. Admin accounts must be created directly via the database or User Management panel.

---

## Rental Request Workflow

```
Tenant submits request
        │
        ▼
  Owner reviews
        │
   ┌────┴────┐
   │         │
Approve    Reject
   │         │
   ▼         ▼
Contract   Notification
created    sent to tenant
   │
   ├── AvailableRooms decremented
   ├── Property marked Rented (if full)
   ├── PDF contract generated
   ├── Email sent to Owner + Tenant
   └── In-app notifications sent
```

After approval, the tenant becomes eligible to leave a review for the property.

---

## Data Models

<details>
<summary>View schema details</summary>

### User
| Field | Type | Constraints |
|---|---|---|
| ID | GUID | PK |
| Name | string | Required, max 100 |
| Email | string | Required, unique |
| Password | string | Stored as PBKDF2 hash |
| Phone | string | Optional, max 20 |
| Role | enum | `Admin` / `Owner` / `Tenant` |

### Property
| Field | Type | Constraints |
|---|---|---|
| ID | GUID | PK |
| OwnerID | string | FK → User (Restrict) |
| Price | decimal | ≥ 0 (DB check) |
| Address | string | 10–255 chars |
| City | string | max 100 |
| Type | enum | `Apartment` / `Studio` / `Villa` |
| Status | enum | `Available` / `Rented` / `Sold` |
| BedRooms | int | 1–50 |
| AvailableRooms | int | 0–50; ≤ BedRooms (DB check) |
| Area | double | 1–100,000 m² |

### Key Constraints
- `Property.AvailableRooms <= Property.BedRooms` — enforced at DB level
- `Request (ClientID, PropertyID)` — unique filtered index on `Status = Pending`, preventing duplicate pending requests
- Cascade deletes: Property → Requests, Reviews, Reports, Images; User → Notifications, Wishlist
- Restricted deletes: User → OwnedProperties, Messages, Contracts (prevents accidental data loss)

### Other Entities
| Entity | Notes |
|---|---|
| **Request** | Tenant application; 1:1 with Contract and Review |
| **Contract** | Auto-created on approval; tracks dates, amount, and status |
| **Review** | One per tenant per property; requires an approved request |
| **Message** | Direct messages scoped to a user pair + property |
| **Notification** | In-app alerts with read/unread state |
| **Wishlist** | Composite PK: `(UserID, PropertyID)` |
| **Report** | Property complaints; Admin-reviewed |
| **Amenity** | Tags (Parking, Pool, WiFi…); linked to Property via many-to-many |

</details>

---

## Security Considerations

> **⚠️ Address the following before any production deployment:**

- **Password comparison** — The `Login` action currently uses plain-text equality. `PasswordHasher.Verify()` is implemented but not yet integrated into the login flow.
- **Seed passwords** — The value `hashed_pass` in seed data is a plain-text legacy placeholder. All accounts must be re-hashed before going live.
- **Session authentication** — The app uses server-side sessions rather than ASP.NET Identity or JWT. Review cookie security, HTTPS enforcement, and session expiry (`IdleTimeout` is set to 8 hours).

---

## License

This project uses the **QuestPDF Community License** for PDF generation.  
See [questpdf.com/license](https://www.questpdf.com/license/) for details.
