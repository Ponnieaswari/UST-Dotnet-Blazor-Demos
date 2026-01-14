# 🛒 Blazor Assignment  
## Mini E-Commerce Application


## 1. Assignment Title  
**Build a Mini E-Commerce Application using Blazor**

---

## 2. Assignment Objective  

The objective of this assignment is to help learners understand and apply **core Blazor concepts** by building a simple **E-commerce web application**.

By completing this assignment, learners will be able to:
- Build UI using **Blazor components**
- Apply **data binding** effectively
- Work with **EditForm and validations**
- Implement **parent-to-child communication**
- Design clean UI using **Bootstrap and CSS**

---

## 3. Technology Stack  

| Technology | Purpose |
|----------|--------|
| .NET 8 / .NET 9 | Application runtime |
| Blazor Web App / Blazor Server | Frontend framework |
| Razor Components | UI development |
| Bootstrap | Styling & layout |
| CSS | Custom styling |
| C# | Business logic |

---

## 4. Application Modules / Screens  

The application should include the following modules:

1. Signup  
2. Login  
3. Product List  
4. Add Product  
5. Product Card (Child Component)

---

## 5. Concepts to Be Covered  

This assignment must demonstrate the following Blazor concepts:

### Blazor Core Concepts
- Component creation using `.razor`
- Routing using `@page`
- Parent and Child components
- Parameter passing using `[Parameter]`
- Event handling

### Data Binding
- One-way data binding
- Two-way data binding using `@bind`
- Object binding

### Forms & Validation
- `EditForm`
- `DataAnnotationsValidator`
- `ValidationSummary`
- Model-based validation

### UI & Styling
- Bootstrap grid system
- Bootstrap cards
- Forms styled using Bootstrap
- Custom CSS enhancements

---

## 6. Detailed Functional Requirements  

---

### 6.1 Signup Component  

**Route:** `/signup`

#### UI Requirements
- Signup form created using `EditForm`
- Fields:
  - Full Name
  - Email
  - Password
  - Confirm Password
- Submit button

#### Functional Requirements
- Use model-based validation
- All fields must be mandatory
- Email must be in valid format
- Password must have a minimum length
- Show success message on successful signup

#### Concepts Covered
- EditForm
- Two-way data binding
- DataAnnotations validation
- Event handling

---

### 6.2 Login Component  

**Route:** `/login`

#### UI Requirements
- Login form using `EditForm`
- Fields:
  - Email
  - Password
- Login button

#### Functional Requirements
- Validate required fields
- Display login success or failure message
- Mock login logic is sufficient (no backend required)

#### Concepts Covered
- EditForm
- Validation
- Event handling

---

### 6.3 Product List Component  

**Route:** `/products`

#### UI Requirements
- Display products using **Bootstrap cards**
- Each card should display:
  - Product Name
  - Description
  - Price

#### Functional Requirements
- Products stored in a collection (`List<Product>`)
- Render product list using `@foreach`
- Use a **Child Component** for displaying each product

#### Concepts Covered
- Collections
- One-way data binding
- Parent to child communication

---

### 6.4 Add Product Component  

**Route:** `/add-product`

#### UI Requirements
- Form using `EditForm`
- Fields:
  - Product Name
  - Description
  - Price
- Submit button

#### Functional Requirements
- Add product to product collection
- Clear form after submission
- Newly added product should appear in Product List

#### Concepts Covered
- EditForm
- Two-way binding
- Event handling

---

### 6.5 Product Card Component (Child Component)  

#### UI Requirements
- Card layout using Bootstrap
- Display product details clearly

#### Functional Requirements
- Receive product data from parent component
- Use `[Parameter]` attribute for data binding

#### Concepts Covered
- Child components
- Parameter binding
- Component reusability

---

## 7. Parent to Child Communication  

- **Product List** acts as the Parent component
- **Product Card** acts as the Child component
- Product data must be passed using `[Parameter]`

**Example (Conceptual):**
```razor
<ProductCard Product="product" />
