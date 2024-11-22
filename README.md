# Dynamic Web-Based Form Generator

This project implements a dynamic web-based form generator that renders forms based on a JSON configuration. The application collects user inputs, validates them, and generates a response in JSON format.

---

## Steps to Run the Application

1. **Ensure Compatibility**:
   - Install **Visual Studio 2022**, as the project was developed using this version. Other versions may require additional configuration.

2. **Open the Solution**:
   - Open the solution in Visual Studio 2022.

3. **Configure Startup Projects**:
   - Set both `Intranet.Interview.UI` and `Intranet.Interview.API` as multiple startup projects:
     - Right-click the solution → **Properties** → **Startup Project** → **Multiple startup projects**.
     - Set both projects to "Start".

4. **Verify API Base URL**:
   - Open the `appsettings.json` file in both the `Intranet.Interview.UI` and `Intranet.Interview.UI.Client` projects.
   - Ensure the `WebApiBaseUrl` is set to `https://localhost:7009/`. If the API URL changes, update these files accordingly.

5. **Restore Dependencies**:
   - Restore NuGet packages to ensure all dependencies are installed.

6. **Build and Run**:
   - Build the solution and run the projects. The application will open in your browser, with the UI rendered by **Blazor WebAssembly** and the backend API handling requests.

---

## Design Considerations and Architecture Decisions

### a. Clean Architecture
The application follows **Clean Architecture** principles to ensure modularity, scalability, and maintainability:
- **Presentation Layer**: 
  - User interface built with **Blazor WebAssembly** and styled using **MudBlazor** for a modern, responsive design.
- **Application Layer**: 
  - Contains business logic and validation rules, ensuring separation of concerns.
- **Domain Layer**: 
  - Defines core business entities and validation logic.
- **Infrastructure Layer**: 
  - Provides in-memory storage.

### b. Dynamic JSON-Based Form Generation
- Forms are dynamically generated from a JSON structure, offering flexibility for future enhancements.
- Validation rules (e.g., required fields, email format, number ranges) are associated with the form fields.

### c. Stateless Backend
- The backend is stateless and uses an in-memory database for temporary data persistence, aligning with project constraints (no external database integration).

### d. Reusability and Scalability
- The modular architecture allows seamless integration of additional features like cross-field validations and WYSIWYG form designers.
- New field types and validation rules can be easily added.

---

## Assumptions Made During Development

### 1. Dynamic Form Scope
- The primary use case is generating person-related forms dynamically, collecting user input, and sending data to the server for saving in an in-memory database.

### 2. Validation Rules
- Basic validation rules (e.g., required fields, email formatting, number range checks) were implemented.
- Custom or cross-field validation is excluded in this version but can be added in future iterations.
- If a field does not have the required attribute, it means it is optional, such as age.

### 3. In-Memory Database
- Data is stored temporarily using an in-memory database. Data will not persist after the application stops.

### 4. JSON Structure Consistency
- It is assumed that the provided JSON structure is valid and adheres to the expected format. Minimal error handling is implemented for malformed JSON.

### 5. Development Timeframe
- Development was completed within the estimated **10±2 hours**, focusing on critical features (dynamic form rendering, data collection, validation) over optional enhancements.

### 6. Web API and UI Communication
- The frontend and backend communicate via RESTful API calls.
- It is assumed that both frontend and backend are hosted on the same local machine during development.
