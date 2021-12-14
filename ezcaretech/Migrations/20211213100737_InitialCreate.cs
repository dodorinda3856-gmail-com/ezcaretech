using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ezcaretech.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ADMIN");

            migrationBuilder.CreateTable(
                name: "COMMON_CODE",
                schema: "ADMIN",
                columns: table => new
                {
                    IDENTIFIER = table.Column<decimal>(type: "NUMBER", nullable: false),
                    NAME = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    REGIS_DATE = table.Column<DateTime>(type: "TIMESTAMP(6)", precision: 6, nullable: true),
                    DELETE_OR_NOT = table.Column<string>(type: "CHAR(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CODE_NAME = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C005169", x => x.IDENTIFIER);
                });

            migrationBuilder.CreateTable(
                name: "MEDI_PROCEDURE",
                schema: "ADMIN",
                columns: table => new
                {
                    MEDI_PROCEDURE_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    TREATMENT_AMOUNT = table.Column<decimal>(type: "NUMBER", nullable: false),
                    CREATETION_DATE = table.Column<DateTime>(type: "DATE", nullable: false),
                    REVISED_DATE = table.Column<DateTime>(type: "DATE", nullable: true),
                    DELETE_DATE = table.Column<DateTime>(type: "DATE", nullable: true),
                    DELETE_OR_NOT = table.Column<string>(type: "CHAR(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEDI_PROCEDURE", x => x.MEDI_PROCEDURE_ID);
                });

            migrationBuilder.CreateTable(
                name: "MEDI_STAFF",
                schema: "ADMIN",
                columns: table => new
                {
                    STAFF_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    STAFF_NAME = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: false),
                    GENDER = table.Column<string>(type: "CHAR(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    MEDI_SUBJECT = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: false),
                    PHONE_NUM = table.Column<string>(type: "VARCHAR2(11)", unicode: false, maxLength: 11, nullable: true),
                    STAFF_EMAIL = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    POSITION = table.Column<string>(type: "CHAR(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C005177", x => x.STAFF_ID);
                });

            migrationBuilder.CreateTable(
                name: "PATIENT",
                schema: "ADMIN",
                columns: table => new
                {
                    PATIENT_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    RESIDENT_REGIST_NUM = table.Column<string>(type: "VARCHAR2(13)", unicode: false, maxLength: 13, nullable: false),
                    ADDRESS = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: true),
                    PATIENT_NAME = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: false),
                    PHONE_NUM = table.Column<string>(type: "VARCHAR2(11)", unicode: false, maxLength: 11, nullable: false),
                    REGIST_DATE = table.Column<DateTime>(type: "TIMESTAMP(6)", precision: 6, nullable: false),
                    GENDER = table.Column<string>(type: "CHAR(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    DOB = table.Column<DateTime>(type: "DATE", nullable: false),
                    PATIENT_STATUS_VAL = table.Column<string>(type: "CHAR(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    AGREE_OF_ALARM = table.Column<string>(type: "CHAR(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PATIENT", x => x.PATIENT_ID);
                });

            migrationBuilder.CreateTable(
                name: "PUSH_ALARM",
                schema: "ADMIN",
                columns: table => new
                {
                    ALARM_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    ALARAM_CONTENT = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: true),
                    TRANSMISSION_DATE = table.Column<DateTime>(type: "TIMESTAMP(6)", precision: 6, nullable: true),
                    ALARM_CLASSIFICATION = table.Column<string>(type: "CHAR(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C005201", x => x.ALARM_ID);
                });

            migrationBuilder.CreateTable(
                name: "NAME_OF_DISEASE",
                schema: "ADMIN",
                columns: table => new
                {
                    DISEASE_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    MEDI_PROCEDURE_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    DISEASE_NAME = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false),
                    CREATION_DATE = table.Column<DateTime>(type: "DATE", nullable: false),
                    REVISED_DATE = table.Column<DateTime>(type: "DATE", nullable: true),
                    DELETE_DATE = table.Column<DateTime>(type: "DATE", nullable: true),
                    DELETE_OR_NOT = table.Column<string>(type: "CHAR(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C005185", x => x.DISEASE_ID);
                    table.ForeignKey(
                        name: "SYS_C005213",
                        column: x => x.MEDI_PROCEDURE_ID,
                        principalSchema: "ADMIN",
                        principalTable: "MEDI_PROCEDURE",
                        principalColumn: "MEDI_PROCEDURE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MEDI_STAFF_LOGIN",
                schema: "ADMIN",
                columns: table => new
                {
                    STAFF_LOGIN_ID = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: false),
                    STAFF_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    STAFF_LOGIN_PW = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C005180", x => x.STAFF_LOGIN_ID);
                    table.ForeignKey(
                        name: "SYS_C005214",
                        column: x => x.STAFF_ID,
                        principalSchema: "ADMIN",
                        principalTable: "MEDI_STAFF",
                        principalColumn: "STAFF_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WAITING",
                schema: "ADMIN",
                columns: table => new
                {
                    WATING_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    PATIENT_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    REQUEST_TO_WAIT = table.Column<DateTime>(type: "TIMESTAMP(6)", precision: 6, nullable: false),
                    REQUIREMENTS = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    RESERVE_STATUS_VAL = table.Column<string>(type: "CHAR(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C005212", x => x.WATING_ID);
                    table.ForeignKey(
                        name: "SYS_C005220",
                        column: x => x.PATIENT_ID,
                        principalSchema: "ADMIN",
                        principalTable: "PATIENT",
                        principalColumn: "PATIENT_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TREATMENT",
                schema: "ADMIN",
                columns: table => new
                {
                    TREAT_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    PATIENT_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    STAFF_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    DISEASE_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    TREAT_DETAILS = table.Column<string>(type: "CLOB", nullable: false),
                    PRESCRIPTION = table.Column<string>(type: "CLOB", nullable: true),
                    TREAT_DATE = table.Column<DateTime>(type: "TIMESTAMP(6)", precision: 6, nullable: false),
                    TREAT_STATUS__VAL = table.Column<string>(type: "CHAR(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C005208", x => x.TREAT_ID);
                    table.ForeignKey(
                        name: "SYS_C005215",
                        column: x => x.STAFF_ID,
                        principalSchema: "ADMIN",
                        principalTable: "MEDI_STAFF",
                        principalColumn: "STAFF_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C005217",
                        column: x => x.DISEASE_ID,
                        principalSchema: "ADMIN",
                        principalTable: "NAME_OF_DISEASE",
                        principalColumn: "DISEASE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C005219",
                        column: x => x.PATIENT_ID,
                        principalSchema: "ADMIN",
                        principalTable: "PATIENT",
                        principalColumn: "PATIENT_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PAYMENT",
                schema: "ADMIN",
                columns: table => new
                {
                    PAYMENT_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    PATIENT_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    TREAT_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    DISEASE_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    PAYMENT_DATE = table.Column<DateTime>(type: "TIMESTAMP(6)", precision: 6, nullable: true),
                    ORIGIN_AMOUNT = table.Column<decimal>(type: "NUMBER", nullable: true),
                    DISCOUNT_AMOUNT = table.Column<decimal>(type: "NUMBER", nullable: true),
                    FIN_PAYMENT_AMOUNT = table.Column<decimal>(type: "NUMBER", nullable: false),
                    CREATION_DATE = table.Column<DateTime>(type: "DATE", nullable: false),
                    REVISED_DATE = table.Column<DateTime>(type: "DATE", nullable: true),
                    DELETE_DATE = table.Column<DateTime>(type: "DATE", nullable: true),
                    DELETE_OR_NOT = table.Column<string>(type: "CHAR(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAYMENT", x => x.PAYMENT_ID);
                    table.ForeignKey(
                        name: "SYS_C005216",
                        column: x => x.DISEASE_ID,
                        principalSchema: "ADMIN",
                        principalTable: "NAME_OF_DISEASE",
                        principalColumn: "DISEASE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C005218",
                        column: x => x.PATIENT_ID,
                        principalSchema: "ADMIN",
                        principalTable: "PATIENT",
                        principalColumn: "PATIENT_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SYS_C005221",
                        column: x => x.TREAT_ID,
                        principalSchema: "ADMIN",
                        principalTable: "TREATMENT",
                        principalColumn: "TREAT_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MEDI_STAFF_LOGIN_STAFF_ID",
                schema: "ADMIN",
                table: "MEDI_STAFF_LOGIN",
                column: "STAFF_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NAME_OF_DISEASE_MEDI_PROCEDURE_ID",
                schema: "ADMIN",
                table: "NAME_OF_DISEASE",
                column: "MEDI_PROCEDURE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PAYMENT_DISEASE_ID",
                schema: "ADMIN",
                table: "PAYMENT",
                column: "DISEASE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PAYMENT_PATIENT_ID",
                schema: "ADMIN",
                table: "PAYMENT",
                column: "PATIENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PAYMENT_TREAT_ID",
                schema: "ADMIN",
                table: "PAYMENT",
                column: "TREAT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TREATMENT_DISEASE_ID",
                schema: "ADMIN",
                table: "TREATMENT",
                column: "DISEASE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TREATMENT_PATIENT_ID",
                schema: "ADMIN",
                table: "TREATMENT",
                column: "PATIENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TREATMENT_STAFF_ID",
                schema: "ADMIN",
                table: "TREATMENT",
                column: "STAFF_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WAITING_PATIENT_ID",
                schema: "ADMIN",
                table: "WAITING",
                column: "PATIENT_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COMMON_CODE",
                schema: "ADMIN");

            migrationBuilder.DropTable(
                name: "MEDI_STAFF_LOGIN",
                schema: "ADMIN");

            migrationBuilder.DropTable(
                name: "PAYMENT",
                schema: "ADMIN");

            migrationBuilder.DropTable(
                name: "PUSH_ALARM",
                schema: "ADMIN");

            migrationBuilder.DropTable(
                name: "WAITING",
                schema: "ADMIN");

            migrationBuilder.DropTable(
                name: "TREATMENT",
                schema: "ADMIN");

            migrationBuilder.DropTable(
                name: "MEDI_STAFF",
                schema: "ADMIN");

            migrationBuilder.DropTable(
                name: "NAME_OF_DISEASE",
                schema: "ADMIN");

            migrationBuilder.DropTable(
                name: "PATIENT",
                schema: "ADMIN");

            migrationBuilder.DropTable(
                name: "MEDI_PROCEDURE",
                schema: "ADMIN");
        }
    }
}
