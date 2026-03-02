# CetStudentBook

ASP.NET MVC project for managing students and books.

#### Assignment: Books CRUD

### What I Implemented

### Book Model

The Book model includes the following fields with validation:
- **Id** (int, primary key)
- **Name** (string, required, 2-200 characters)
- **Author** (string, required, 2-200 characters)
- **PublishDate** (DateTime, required)
- **PageCount** (int, required, 1-10000)
- **IsSecondHand** (bool, required)

I implemented a complete CRUD (Create, Read, Update, Delete) system for the Book entity:

1. **List Page** (`/Books` or `/Books/Index`)
   - Displays all books in a table format
   - Shows columns: Name, Author, PublishDate, PageCount, IsSecondHand
   - Each row has Edit and Delete action buttons

2. **Create Page** (`/Books/Create`)
   - Form to add new books
   - Client-side and server-side validation
   - Redirects to list page after successful creation

3. **Edit/Update Page** (`/Books/Edit/{id}`)
   - Form pre-populated with current book values
   - Validates input and shows error messages
   - Updates the record in the database
   - Handles invalid IDs with NotFound result

4. **Delete Page** (`/Books/Delete/{id}`)
   - Confirmation screen showing book details
   - Deletes the record from database
   - Redirects to list page after deletion
   - Handles invalid IDs with NotFound result

### How to Run the Project Locally

1. **Prerequisites**
   - .NET 9.0 SDK installed
   
2. **Clone the Repository**
   ```bash
   git clone https://github.com/mbatuylmaz/CetStudentBook.git
   cd CetStudentBook/CetStudentBook
   ```

3. **Restore Packages**
   ```bash
   dotnet restore
   ```

4. **Database Setup**
   The project uses SQLite database. Run the following command to apply migrations:
   ```bash
   dotnet ef database update
   ```
   Or if using Package Manager Console in Visual Studio:
   ```
   Update-Database
   ```

5. **Run the Application**
   ```bash
   dotnet run
   ```
   The application will start and you can access it at `https://localhost:5001` or `http://localhost:5000`

6. **Access Books Pages**
   - Navigate to the "Books" link in the main navigation menu
   - Or go directly to `/Books` route

### Database/Migration Steps

The project uses Entity Framework Code First approach:

1. **Check existing migrations:**
   ```bash
   dotnet ef migrations list
   ```

2. **Create a new migration (if needed):**
   ```bash
   dotnet ef migrations add MigrationName
   ```

3. **Apply migrations to database:**
   ```bash
   dotnet ef database update
   ```

The Books table was created using migration `20260302005218_AddBooksTable`.

### Screenshots

#### Books List Page
![Books List Page](screenshots/books-list.png)
The list page displays all books in a table format with columns for Name, Author, Publish Date, Page Count, and Is Second Hand status. Each row includes Edit and Delete action buttons.

#### Edit Page with Validation Errors
![Edit Page with Validation Errors](screenshots/edit-validation.png)
The edit page shows validation errors when input doesn't meet requirements. In this example, the Author field shows an error because "S" is too short (minimum 2 characters), and Page Count shows an error because "0" is outside the valid range (1-10000).

#### Delete Confirmation Page
![Delete Confirmation Page](screenshots/delete-confirmation.png)
The delete page displays a confirmation screen showing all book details before deletion. Users can review the information and confirm or cancel the deletion.

### Navigation

The "Books" link has been added to the shared layout (`_Layout.cshtml`) in the main navigation menu, allowing easy access to the Books list page from anywhere in the application.