using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalDB.Migrations
{
    public partial class InitializedData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "s19047@pjwstk.edu.pl", "Ahmad", "Alaziz" },
                    { 2, "AliceLashuk@gmail.com", "Alice", "Lashuk" },
                    { 3, "Roma@gmail.com", "Roman", "Isianko" }
                });

            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Alaziz", "Med1", "KushKush" },
                    { 2, "Lashuk", "Med2", "SmokeTillYouDrop" },
                    { 3, "Isianko", "Med3", "420" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Max", "Alaziz" },
                    { 2, new DateTime(1982, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Connor", "Lashuk" },
                    { 3, new DateTime(1977, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khabib", "Isianko" }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 3, new DateTime(1996, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 2, new DateTime(1967, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 1, new DateTime(1999, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 2, 2, "wedfwef", 23 });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 3, 2, "swefwe", 45 });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 1, 1, "ksdlsd", 31 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3);
        }
    }
}
