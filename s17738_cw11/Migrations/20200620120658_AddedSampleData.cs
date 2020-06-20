using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace s17738_cw11.Migrations
{
    public partial class AddedSampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "nowak@ddd.com", "Adam", "Nowak" },
                    { 2, "kowalski@ddd.com", "Jan", "Kowalski" },
                    { 3, "kasian@ddd.com", "Kasia", "Nowak" }
                });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "For headache", "Ibuprom", "basic" },
                    { 2, "For headache", "Apap", "basic" },
                    { 3, "For headache", "Nospa", "basic" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Idpatient", "Birthdate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 20, 14, 6, 57, 557, DateTimeKind.Local).AddTicks(3600), "Marcin", "Adamczyk" },
                    { 2, new DateTime(2020, 6, 20, 14, 6, 57, 560, DateTimeKind.Local).AddTicks(9910), "Tomasz", "Malinowski" },
                    { 3, new DateTime(2020, 6, 20, 14, 6, 57, 561, DateTimeKind.Local).AddTicks(70), "Monika", "Domska" }
                });

            migrationBuilder.InsertData(
                table: "PrescriptionMedicaments",
                columns: new[] { "IdPrescription", "IdMedicament", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "none", null },
                    { 1, 3, "1x1", null },
                    { 2, 1, "2x2", null }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 1, new DateTime(2020, 6, 20, 14, 6, 57, 564, DateTimeKind.Local).AddTicks(6460), new DateTime(2020, 7, 20, 14, 6, 57, 564, DateTimeKind.Local).AddTicks(7160), 1, 1 });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 2, new DateTime(2020, 6, 20, 14, 6, 57, 564, DateTimeKind.Local).AddTicks(9280), new DateTime(2020, 7, 20, 14, 6, 57, 564, DateTimeKind.Local).AddTicks(9310), 2, 2 });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 3, new DateTime(2020, 6, 20, 14, 6, 57, 564, DateTimeKind.Local).AddTicks(9350), new DateTime(2020, 7, 20, 14, 6, 57, 564, DateTimeKind.Local).AddTicks(9350), 3, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdPrescription", "IdMedicament" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdPrescription", "IdMedicament" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdPrescription", "IdMedicament" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Idpatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Idpatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Idpatient",
                keyValue: 3);
        }
    }
}
