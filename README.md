# Delivery app

This is a scalable, cloud-ready delivery management system built with .NET Core and microservices architecture. It enables seamless order processing, real-time tracking, and optimized logistics for efficient deliveries.

![image](https://github.com/user-attachments/assets/88224ec9-3ea6-439a-98eb-ead3bbf43f83)


---

## 🚀 Features
- **Product Catalog Management** CRUD operations for menu items/products.
- **Shopping Cart** Persistent cart storage per user.
- **Discount Coupons** API for validating and applying discounts.
- **User Authentication & Authorization** JWT-based authentication via Identity Server.
- **Order Processing Workflow** Order placement, validation, and lifecycle management.
- **Payment Integration** Simulated payment processing and event-driven workflow.
- **Loyalty Rewards** Reward system for customers based on order history.
- **Email Notifications** Event-driven email confirmation and order updates.
- **API Gateway** Centralized API routing using Ocelot


---

## 🛠️ Tech Stack

### **Frontend**
- **Razor Pages** 
- **Bootstrap 5**

### **Backend**
- **.NET Core**
- **ASP.NET Web API**
- **Stripe API** for subscription management
- **Entity Framework Core**
- **SQL Server** for the database

### **DevOps**
- **Azure** for Deployment
- **GitHub Actions** for CI/CD

---

## 📦 Installation

## **1. Clone the Repository**
```bash
git clone https://github.com/BojanSkopljakk/delivery.git
cd delivery

```

### **2. Configure SQL Server and Azure Services manually.**

### **3. Update connection strings in each microservice's appsettings.json**

### **4. Run each microservice separately**

### **5. Start Mango.Web project and access the front-end.**

## **📂 Project Structure**
```ruby
Mango_Microservices/
├── Mango.Web/             # Frontend Web Application (ASP.NET MVC)
├── Mango.GatewaySolution/ # API Gateway (Ocelot)
├── Mango.Services.AuthAPI/  # User Authentication
├── Mango.Services.ProductAPI/ # Product Management
├── Mango.Services.ShoppingCartAPI/ # Shopping Cart Service
├── Mango.Services.CouponAPI/ # Coupon Service
├── Mango.Services.OrderAPI/ # Order Processing
├── Mango.Services.RewardAPI/ # Reward System
├── Mango.Services.EmailAPI/ # Email Notifications
├── Mango.MessageBus/       # Shared message library
```


## **🔮 Future Improvements**
- ✅ Make Azure Deployment fully functional
- ✅ Unit tests, integration tests, and load testing



