# 🛒 Blazor Assignment  
## Mini E-Commerce Application (With Validation, Services & State Management)

---

## 1. Assignment Title  
**Build a Mini E-Commerce Application using Blazor**

---

## 2. Assignment Objective  

The objective of this assignment is to help learners build a **realistic Blazor application** by applying:

- Component-based UI development
- Form handling with validation
- Shared services and state management
- Parent–Child communication
- Clean UI using Bootstrap and CSS

By completing this assignment, learners will understand how **real Blazor applications are structured**.

---

## 3. Technology Stack  

| Technology | Purpose |
|----------|--------|
| .NET 8 / .NET 9 | Runtime |
| Blazor Web App / Blazor Server | Frontend framework |
| Razor Components | UI |
| Bootstrap | Styling |
| CSS | UI customization |
| C# | Logic & Models |

---

## 4. Application Modules  

The application must include the following modules:

1. Signup  
2. Login  
3. Dashboard  
4. Product List  
5. Add Product  
6. Product Card (Child Component)

---

## 5. Core Concepts to Be Covered  

### Blazor Fundamentals
- Component creation (`.razor`)
- Routing using `@page`
- Layout usage
- Parent & Child components
- Parameter passing (`[Parameter]`)

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
- Login state management
- Product state management

---

## 6. Application State Management Requirement  

The application **must use shared services** to manage state.

### Required State Objects:
- Logged-in user information
- Product collection

### Example Services:
- `AuthStateService` → Login state
- `ProductService` → Product list state

---

## 7. Detailed Functional Requirements  

---

## 7.1 Signup Component  

**Route:** `/signup`

### UI Requirements
- Signup form using `EditForm`
- Fields:
  - Full Name
  - Email
  - Password
  - Confirm Password
- Submit button

### Validation Requirements
- All fields required
- Email format validation
- Password minimum length (6)
- Confirm password must match password

### Functional Requirements
- Use **model-based validation**
- Show validation messages using:
  - `ValidationSummary`
- Show success alert on signup

### Concepts Covered
- EditForm
- DataAnnotations validation
- Two-way data binding

---

## 7.2 Login Component  

**Route:** `/login`

### UI Requirements
- Login form using `EditForm`
- Fields:
  - Email
  - Password
- Login button

### Validation Requirements
- Required field validation
- Email format validation

### State Management Requirements
- On successful login:
  - Store login status in `AuthStateService`
  - Store logged-in user name/email

### Functional Requirements
- Redirect user to Dashboard after login

### Concepts Covered
- EditForm
- Validation
- Shared state using service

---

## 7.3 Dashboard Component  

**Route:** `/dashboard`

### UI Requirements
- Welcome message using logged-in user name
- Logout button

### State Management Requirements
- Read login state from `AuthStateService`
- If user is not logged in:
  - Show warning message
  - Redirect to Login page

### Functional Requirements
- Logout clears state and redirects to Login

### Concepts Covered
- State management
- Conditional rendering
- Navigation

---

## 7.4 Product List Component  

**Route:** `/products`

### UI Requirements
- Display products using **Bootstrap cards**
- Each card should display:
  - Product Name
  - Description
  - Price

### State Management Requirements
- Products must be stored in `ProductService`
- Product List component must read data from the service

### Functional Requirements
- Render products using `@foreach`
- Use a **Product Card child component**

### Concepts Covered
- Shared service
- One-way binding
- Parent → Child communication

---

## 7.5 Add Product Component  

**Route:** `/add-product`

### UI Requirements
- Product form using `EditForm`
- Fields:
  - Product Name
  - Description
  - Price
- Submit button

### Validation Requirements
- All fields required
- Price must be greater than 0

### State Management Requirements
- On submit:
  - Add product to `ProductService`
- Product list should update automatically

### Concepts Covered
- EditForm
- Validation
- Two-way binding
- Service-based state update

---

## 7.6 Product Card Component (Child Component)  

### UI Requirements
- Bootstrap card layout
- Display product details

### Functional Requirements
- Receive product object from parent using `[Parameter]`

### Concepts Covered
- Child component
- Parameter binding
- Component reusability

---

## 8. Parent → Child Communication  

- **Product List** is the Parent
- **Product Card** is the Child
- Product data must be passed using `[Parameter]`

Example:
```razor
<ProductCard Product="product" />
