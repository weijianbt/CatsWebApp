# CatsWebApp

<h1>Tutorial on ASP.NET Core</h1>

<h2>Introduction on ASP.NET</h2>

What is ASP.NET Core?
- Microsoft C# tool to build web applications.
- Similar to PHP Laravel, Python Flask, Node.js

What is .NET?
- Microsoft's Software Development Platform
- Including Desktop(WPF), Web(ASP.NET), Azure, Mobile(Xamarin) and many more
- The .NET framework is language neutral. Supporting > 20 languages (C#, C++, VB, Java, Ruby, Python...)

What is ASP?
- Active Server Pages - Dynamic web pages

What is Core?
- Microsoft's open source, cross-platform version of ASP for developing software

Why do we need ASP.NET?
- Around 1997, there was a migration from desktop application to browser based web applications
- From WinForm (form-based application) --> Web based application

More details on ASP.NET:
- An ASP.NET page is a web page that contains a mix of HTML markup & dynamic ASP markup
- ASP.NET runs on the server, combining the static HTML code, and updating dynamic ASP elements to produce a final HTML page
- ASP.NET web page is also known as Web Forms
- It is full stack (db, business logic, HTML)
- Can be combined with popular FE services (React, Angular, Vue)

<h2>Introduction to the concept of "Models, View and Controllers(MVC)"</h2>

What is MVC?
- A design pattern to help enforce separation of concerns to avoid mixing presentation logic, business logic & data access logic together.
	- Model = classes (objects). Manages the behaviour and data.
	- View = web page (Razor HTML). Manages the display of data.
	- Controller = connects models, business logics and web pages. Handles page events and navigation between pages. It tells the pages when to appear, and gives them data that the page can show.
- This allows a smaller file size, and a modular code design

General flow.
1. User provides request (etc: orders from today)
1. The request is passed from the router to the controller
1. The controller will get the data from the model (Orders oList = Store.getOrders(today))
1. The model will grab from the database (SELECT * FROM Orders WHERE Date = 'today')
1. The model will send the returned data to the controller
1. Controller will send it to the view (Get View("showOrders.html", oList))
1. View generates a list of orders (using list tags)