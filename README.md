# Login-and-Register-System
Login and Register System using C# for Windows Forms

<p align="center">
  <a href="#-technologies">Technologies</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-how-to-use">How to use</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-license">License</a>
</p>
<div align="center" style="margin: 20px; text-align: center">

  [![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](https://github.com/BinaryLeo/Login-and-Register-System/blob/main/LICENSE)
  ![GitHub last commit](https://img.shields.io/github/last-commit/BinaryLeo/Login-and-Register-System?style=flat-square)
  ![GitHub top language](https://img.shields.io/github/languages/top/BinaryLeo/Login-and-Register-System?style=flat-square)

</div>

<div align="center"><img src="https://user-images.githubusercontent.com/72607039/156090075-28dbf5fc-0420-4992-bab8-b6e49125e1de.gif" width=50% height=50%></div>


![system](https://user-images.githubusercontent.com/72607039/156092525-4d081ef4-b314-4517-a298-a3a2fb6813bb.png)




## 🧪 technologies

This project was built using the following technologies and features:

- C#
- [PostgreSQL](https://www.postgresql.org/)
- [NpgSql](https://www.npgsql.org/)
- [Visual Studio IDE](https://visualstudio.microsoft.com)

## 💡 how to use

- Clone the repository.
- open the project from Visual Studio 2022.
- Rename the file from <code>APP_config.xml</code> to <code>app.config</code> and in the below code section type your database credentials.


<code>
  &ltappSettings&gt
		&ltadd key="MyConnection" value=Server=" ";Port=" ";Database=" ";User Id = " "; Password=" " &gt
 &lt/appSettings&gt
</code>
                                                                                               

- Database structure
For this application, we are using A local PostgreSQL Database. 
 
  Table name : csharp_user
  
   
``` sql
create TABLE IF NOT EXISTS csharp_user(
    id Serial ,
    username VARCHAR NOT NULL,
    password VARCHAR NOT NULL,
    PRIMARY KEY (id)
)
```

``` sql
INSERT into csharp_user(username,password) values('admin', 'admin') 
```

## 📄 License

This project was built under MIT. See the file [LICENSE](LICENSE) for more details.

---
