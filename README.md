# ContactsApp

## ContactsAPI:
ContactsAPI is a backend solution that provides CRUD operations to ContactsApp. It connects to Azure SQL Server database. The solution is built on .NET5 Web API and hosted on Azure App Service. 

## ContactsApp.Client:
ContactsApp is a front-end solution built on .NET5 Blazor that runs directly on client's browser via web assemblies. It makes calls to ContactsAPI to read/write application data using Http client. The website is hosted on Azure App Service.

To access the website please follow the URL:
http://contactsapp-ktech.azurewebsites.net/

# Notes:
* The website and the backend are hosted on Free App Service plan. Due to that, the access to the website is limited to 60 mintues per day. 
* The infrastructure resources are pretty basic. There might be some delay or slow downs when reading/writing data.
* There is no image compression solution implemented, uploading large image files will slow down site performance. 
