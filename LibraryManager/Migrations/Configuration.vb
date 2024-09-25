Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq

Namespace Migrations

    Friend NotInheritable Class Configuration
        Inherits DbMigrationsConfiguration(Of LM)

        Public Sub New()
            AutomaticMigrationsEnabled = True
        End Sub

        Protected Overrides Sub Seed(context As LM)
            '  This method will be called after migrating to the latest version.

            '  You can use the DbSet(Of T).AddOrUpdate() helper extension method
            '  to avoid creating duplicate seed data.

            ' Seed Users
            context.Users.AddOrUpdate(
                Function(u) u.Email,
                New User With {.Username = "johndoe", .Email = "john.doe@example.com", .Password = "Password123"},
                New User With {.Username = "janesmith", .Email = "jane.smith@example.com", .Password = "Password456"},
                New User With {.Username = "alicejohnson", .Email = "alice.johnson@example.com", .Password = "Password789"},
                New User With {.Username = "robertbrown", .Email = "robert.brown@example.com", .Password = "Password987"},
                New User With {.Username = "michaelclark", .Email = "michael.clark@example.com", .Password = "Password654"}
            )

            ' Seed Books
            context.Books.AddOrUpdate(
                Function(b) b.ISBN,
                New Book With {.ISBN = "9781234567890", .Title = "Introduction to Programming", .Authors = "John Smith", .Publisher = "Tech Press", .PublisherYear = 2020},
                New Book With {.ISBN = "9780987654321", .Title = "Advanced Algorithms", .Authors = "Jane Doe", .Publisher = "Academic Press", .PublisherYear = 2019},
                New Book With {.ISBN = "9781122334455", .Title = "Database Systems", .Authors = "Alice Brown", .Publisher = "Data Publishers", .PublisherYear = 2021},
                New Book With {.ISBN = "9785566778899", .Title = "Computer Networks", .Authors = "Robert Green", .Publisher = "Net Press", .PublisherYear = 2022},
                New Book With {.ISBN = "9786677889900", .Title = "Artificial Intelligence", .Authors = "Michael Lee", .Publisher = "AI Publishers", .PublisherYear = 2023}
            )

            ' Seed Students
            context.Students.AddOrUpdate(
                Function(s) s.Email,
                New Student With {.Firstname = "John", .Lastname = "Doe", .Middlename = "A.", .Sex = "Male", .Telephone = "1234567890", .Email = "john.doe@student.com", .Course = "Computer Science"},
                New Student With {.Firstname = "Jane", .Lastname = "Smith", .Middlename = "B.", .Sex = "Female", .Telephone = "0987654321", .Email = "jane.smith@student.com", .Course = "Mathematics"},
                New Student With {.Firstname = "Alice", .Lastname = "Johnson", .Middlename = "C.", .Sex = "Female", .Telephone = "1122334455", .Email = "alice.johnson@student.com", .Course = "Physics"},
                New Student With {.Firstname = "Robert", .Lastname = "Brown", .Middlename = "D.", .Sex = "Male", .Telephone = "5566778899", .Email = "robert.brown@student.com", .Course = "Engineering"},
                New Student With {.Firstname = "Michael", .Lastname = "Clark", .Middlename = "E.", .Sex = "Male", .Telephone = "6677889900", .Email = "michael.clark@student.com", .Course = "Chemistry"}
            )

            Try
                ' Save changes to the database
                context.SaveChanges()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
