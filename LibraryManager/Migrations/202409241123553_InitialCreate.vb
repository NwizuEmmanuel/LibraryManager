Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Users",
                Function(c) New With
                    {
                        .Id = c.Int(nullable:=False, identity:=True),
                        .Username = c.String(nullable:=False, maxLength:=50),
                        .Email = c.String(nullable:=False, maxLength:=100),
                        .Password = c.String(nullable:=False)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .Index(Function(t) t.Username, unique:=True) _
                .Index(Function(t) t.Email, unique:=True)

        End Sub
        
        Public Overrides Sub Down()
            DropIndex("dbo.Users", New String() { "Email" })
            DropIndex("dbo.Users", New String() { "Username" })
            DropTable("dbo.Users")
        End Sub
    End Class
End Namespace
