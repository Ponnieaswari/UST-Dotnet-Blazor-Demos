# 🛒 Blazor Assignment  
## Mini E-Commerce Application  
### (With Validation, Services, State Management & Lifecycle Methods)

---

## 1. Assignment Title  
**Build a Mini E-Commerce Application using Blazor**

---

## 2. Assignment Objective  

The objective of this assignment is to help learners build a **realistic Blazor application** that integrates:

- Component-based UI design
- Form handling with validation
- REST API consumption using HttpClient
- Lifecycle method usage
- Shared services and state management
- Parent–Child communication

By completing this assignment, learners will clearly understand **how Blazor components behave throughout their lifecycle**.

---

## 3. Technology Stack  

| Technology | Purpose |
|----------|--------|
| .NET 8 / .NET 9 | Runtime |
| Blazor Web App / Blazor Server | UI Framework |
| Razor Components | UI |
| HttpClient | REST API calls |
| Bootstrap | Styling |
| CSS | Custom UI |
| C# | Business Logic |

---

## 4. Fake REST API to Be Used  

Learners must use **any ONE** of the following fake REST APIs:

- https://dummyjson.com/products  
- https://fakestoreapi.com/products  

These APIs return:
- Product Name
- Description
- Price
- Image

---

## 5. Application Modules  

1. Signup  
2. Login  
3. Dashboard  
4. Product Gallery (API-based)  
5. Add Product (Local state)  
6. Product Card (Child Component)

---

## 6. Core Concepts to Be Covered  

### Blazor Fundamentals
- Component creation (`.razor`)
- Routing using `@page`
- Layout usage
- Parent & Child components
- `[Parameter]` usage

### Data Binding
- One-way binding
- Two-way binding using `@bind`
- Object binding

### Forms & Validation
- `EditForm`
- `DataAnnotationsValidator`
- `ValidationSummary`
- Model-based validation

### Services & State Management
- Creating services
- Dependency Injection (`@inject`)
- Shared application state
- Login & Product state management

### Lifecycle Methods (MANDATORY)
- `OnInitializedAsync`
- `OnParametersSet`
- `OnAfterRenderAsync`

---

## 7. Lifecycle Methods – Mandatory Usage Guidelines  

Learners **must use lifecycle methods appropriately** as below:

| Lifecycle Method | Where to Use | Purpose |
|-----------------|------------|--------|
OnInitializedAsync | Product List | Call REST API |
OnParametersSet | Product Card | React to product data |
OnAfterRenderAsync | Product List | First render logging / JS placeholder |

---

## 8. Application State Management Requirement  

The application **must use shared services**.

### Required Services:
- `AuthStateService` → Login state
- `ProductService` → Product data (API + local)

Services should be registered using:
```csharp
builder.Services.AddSingleton<T>();
