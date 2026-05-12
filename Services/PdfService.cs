using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Sakany.Models;

namespace Sakany.Services
{
    public class PdfService
    {
        public PdfService()
        {
            QuestPDF.Settings.License = LicenseType.Community;
        }

        public byte[] GenerateContractPdf(Contract contract)
        {
            var endDate = contract.EndDate.HasValue
                ? contract.EndDate.Value.ToString("dd MMM yyyy")
                : "Open-ended";

            var statusColor = contract.Status switch
            {
                ContractStatus.Active => "#27ae60",
                ContractStatus.Expired => "#e67e22",
                ContractStatus.Canceled => "#e74c3c",
                _ => "#333333"
            };

            var red = Color.FromHex("#e74c3c");
            var darkBlue = Color.FromHex("#1a1a2e");
            var lightGray = Color.FromHex("#f0f0f0");
            var gray = Color.FromHex("#888888");
            var statusClr = Color.FromHex(statusColor);

            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(40);
                    page.DefaultTextStyle(x => x.FontSize(12).FontColor(Colors.Black));

                    // ── HEADER ──
                    page.Header()
                        .BorderBottom(2).BorderColor(red)
                        .PaddingBottom(12)
                        .Row(row =>
                        {
                            row.AutoItem().Text(text =>
                            {
                                text.Span("Saka").Bold().FontSize(24).FontColor(red);
                                text.Span("ny").Bold().FontSize(24).FontColor(darkBlue);
                            });

                            row.RelativeItem();

                            row.AutoItem().AlignRight().Column(col =>
                            {
                                col.Item().Text("Rental Contract").FontSize(11).FontColor(gray);
                                col.Item().Text($"#{contract.ID.Substring(0, 8).ToUpper()}")
                                    .Bold().FontSize(16).FontColor(darkBlue);
                            });
                        });

                    // ── CONTENT ──
                    page.Content().PaddingTop(20).Column(col =>
                    {
                        // Status badge
                        col.Item().AlignCenter().PaddingBottom(20)
                            .Background(statusClr)
                            .PaddingVertical(5).PaddingHorizontal(14)
                            .Text(contract.Status.ToString().ToUpper())
                            .Bold().FontSize(11).FontColor(Colors.White).LetterSpacing(1);

                        // Owner + Tenant
                        col.Item().PaddingBottom(20).Row(row =>
                        {
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Element(SectionTitle("Owner", red));
                                c.Item().Element(InfoRow("Name", contract.Owner?.Name, gray, darkBlue));
                                c.Item().Element(InfoRow("Email", contract.Owner?.Email, gray, darkBlue));
                                c.Item().Element(InfoRow("Phone", contract.Owner?.Phone ?? "—", gray, darkBlue));
                            });

                            row.ConstantItem(20);

                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Element(SectionTitle("Tenant", red));
                                c.Item().Element(InfoRow("Name", contract.Tenant?.Name, gray, darkBlue));
                                c.Item().Element(InfoRow("Email", contract.Tenant?.Email, gray, darkBlue));
                                c.Item().Element(InfoRow("Phone", contract.Tenant?.Phone ?? "—", gray, darkBlue));
                            });
                        });

                        // Property Details
                        col.Item().PaddingBottom(20).Column(c =>
                        {
                            c.Item().Element(SectionTitle("Property Details", red));
                            c.Item().Element(InfoRow("Address", contract.Property?.Address, gray, darkBlue));
                            c.Item().Element(InfoRow("City", contract.Property?.City, gray, darkBlue));
                            c.Item().Element(InfoRow("Type", contract.Property?.Type.ToString(), gray, darkBlue));
                            c.Item().Element(InfoRow("Area", $"{contract.Property?.Area} m²", gray, darkBlue));
                            c.Item().Element(InfoRow("Bedrooms", contract.Property?.BedRooms.ToString(), gray, darkBlue));
                            c.Item().Element(InfoRow("Bathrooms", contract.Property?.BathRooms.ToString(), gray, darkBlue));
                        });

                        // Contract Period
                        col.Item().PaddingBottom(20).Column(c =>
                        {
                            c.Item().Element(SectionTitle("Contract Period", red));
                            c.Item().Element(InfoRow("Start Date", contract.StartDate.ToString("dd MMM yyyy"), gray, darkBlue));
                            c.Item().Element(InfoRow("End Date", endDate, gray, darkBlue));
                            c.Item().Element(InfoRow("Contract ID", contract.ID, gray, darkBlue));
                            c.Item().Element(InfoRow("Request ID", contract.RequestID, gray, darkBlue));
                        });

                        // Amount Box
                        col.Item().PaddingBottom(24)
                            .Border(2).BorderColor(red)
                            .Background(Color.FromHex("#fff8f8"))
                            .Padding(18).AlignCenter().Column(c =>
                            {
                                c.Item().AlignCenter()
                                    .Text("Monthly Rent")
                                    .FontSize(11).FontColor(gray).LetterSpacing(1);

                                c.Item().AlignCenter().Text(text =>
                                {
                                    text.Span($"EGP {contract.Amount:N0}")
                                        .Bold().FontSize(26).FontColor(red);
                                    text.Span(" / month")
                                        .FontSize(12).FontColor(gray);
                                });
                            });

                        // Signatures
                        col.Item().PaddingTop(30).Row(row =>
                        {
                            row.RelativeItem().Element(SignatureBlock(contract.Owner?.Name, "Owner Signature", darkBlue, gray));
                            row.ConstantItem(40);
                            row.RelativeItem().Element(SignatureBlock(contract.Tenant?.Name, "Tenant Signature", darkBlue, gray));
                        });
                    });

                    // ── FOOTER ──
                    page.Footer()
                        .BorderTop(1).BorderColor(lightGray)
                        .PaddingTop(10)
                        .AlignCenter()
                        .Text($"Generated by Sakany  ·  {DateTime.Now:dd MMM yyyy HH:mm}  ·  " +
                              "This document is auto-generated and serves as an official rental agreement.")
                        .FontSize(10).FontColor(gray);
                });
            });

            return document.GeneratePdf();
        }

        // ── Helpers ──────────────────────────────────────

        private static Action<IContainer> SectionTitle(string title, Color red) => container =>
            container
                .BorderBottom(1).BorderColor(Color.FromHex("#f0f0f0"))
                .PaddingBottom(4).PaddingTop(2)
                .Text(title.ToUpper())
                .Bold().FontSize(10).FontColor(red).LetterSpacing(1);

        private static Action<IContainer> InfoRow(string label, string? value, Color gray, Color dark) => container =>
            container.PaddingVertical(4).Row(row =>
            {
                row.RelativeItem(4).Text(label).FontSize(12).FontColor(gray);
                row.RelativeItem(6).Text(value ?? "—").Bold().FontSize(12).FontColor(dark);
            });

        private static Action<IContainer> SignatureBlock(string? name, string role, Color dark, Color gray) => container =>
            container.Column(c =>
            {
                c.Item().BorderTop(1).BorderColor(Colors.Black).PaddingTop(6).AlignCenter()
                    .Text(name ?? "").Bold().FontSize(12).FontColor(dark);
                c.Item().AlignCenter()
                    .Text(role).FontSize(10).FontColor(gray);
            });
    }
}