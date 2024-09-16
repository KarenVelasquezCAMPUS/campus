# skeletonWebApiEs

a la hora de estar creando el repositorio se debe agregar el readme y agregar el .gitignore con la opcion que dice VisualStudio

Windows PowerShell
Copyright (C) Microsoft Corporation. Todos los derechos reservados.

Instale la versión más reciente de PowerShell para obtener nuevas características y mejoras. https://aka.ms/PSWindows

PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects> git clone https://github.com/KarenVelasquezCAMPUS/skeletonWebApiEs.git
Cloning into 'skeletonWebApiEs'...
remote: Enumerating objects: 7, done.
remote: Counting objects: 100% (7/7), done.
remote: Compressing objects: 100% (6/6), done.
remote: Total 7 (delta 0), reused 0 (delta 0), pack-reused 0
Receiving objects: 100% (7/7), 4.30 KiB | 4.30 MiB/s, done.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects> cd .\skeletonWebApiEs\
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> dotnet new sln
La plantilla "Archivo de la solución" se creó correctamente.

PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> dotnet new classlib -o Dominio
La plantilla "Biblioteca de clases" se creó correctamente.

Procesando acciones posteriores a la creación...
Restaurando C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj:
  Determinando los proyectos que se van a restaurar...
  Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj (en 103 ms).
Restauración realizada correctamente.


PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> dotnet new classlib -o Persistencia
La plantilla "Biblioteca de clases" se creó correctamente.

Procesando acciones posteriores a la creación...
Restaurando C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\Persistencia.csproj:
  Determinando los proyectos que se van a restaurar...
  Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\Persistencia.csproj (en 134 ms).
Restauración realizada correctamente.


PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> dotnet new classlib -o Aplicacion
La plantilla "Biblioteca de clases" se creó correctamente.

Procesando acciones posteriores a la creación...
Restaurando C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Aplicacion\Aplicacion.csproj:
  Determinando los proyectos que se van a restaurar...
  Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Aplicacion\Aplicacion.csproj (en 125 ms).
Restauración realizada correctamente.


PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> dotnet new classlib -o Seguridad
La plantilla "Biblioteca de clases" se creó correctamente.

Procesando acciones posteriores a la creación...
Restaurando C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\Seguridad.csproj:
  Determinando los proyectos que se van a restaurar...
  Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\Seguridad.csproj (en 87 ms).
Restauración realizada correctamente.


PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> dotnet new webapi -o skeletonEsApi
La plantilla "ASP.NET Core Web API" se creó correctamente.

Procesando acciones posteriores a la creación...
Restaurando C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj:
  Determinando los proyectos que se van a restaurar...
  Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj (en 281 ms).
Restauración realizada correctamente.


PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> dir


    Directorio: C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs


Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
da---l      31/08/2023  6:48 a. m.                Aplicacion
da---l      31/08/2023  6:48 a. m.                Dominio
da---l      31/08/2023  6:48 a. m.                Persistencia
da---l      31/08/2023  6:48 a. m.                Seguridad
da---l      31/08/2023  6:48 a. m.                skeletonEsApi
-a---l      31/08/2023  6:47 a. m.           7258 .gitignore
-a---l      31/08/2023  6:47 a. m.            151 README.md
-a---l      31/08/2023  6:47 a. m.            441 skeletonWebApiEs.sln


PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> dotnet sln add .\Aplicacion\
Se ha agregado el proyecto "Aplicacion\Aplicacion.csproj" a la solución.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> dotnet sln add .\Dominio\
Se ha agregado el proyecto "Dominio\Dominio.csproj" a la solución.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> dotnet sln add .\Persistencia\
Se ha agregado el proyecto "Persistencia\Persistencia.csproj" a la solución.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> dotnet sln add .\Seguridad\
Se ha agregado el proyecto "Seguridad\Seguridad.csproj" a la solución.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> dotnet sln add .\skeletonEsApi\
Se ha agregado el proyecto "skeletonEsApi\skeletonEsApi.csproj" a la solución.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> dotnet sln list
Proyectos
---------
Aplicacion\Aplicacion.csproj
Dominio\Dominio.csproj
Persistencia\Persistencia.csproj
Seguridad\Seguridad.csproj
skeletonEsApi\skeletonEsApi.csproj
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> cd .\Aplicacion\
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Aplicacion> dotnet add reference ..\Dominio\
Se ha agregado la referencia "..\Dominio\Dominio.csproj" al proyecto.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Aplicacion> dotnet add reference ..\Persistencia\
Se ha agregado la referencia "..\Persistencia\Persistencia.csproj" al proyecto.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Aplicacion> cd ..
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> cd .\skeletonEsApi\
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi> dotnet add reference ..\Aplicacion\
Se ha agregado la referencia "..\Aplicacion\Aplicacion.csproj" al proyecto.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi> dotnet add reference ..\Seguridad\
Se ha agregado la referencia "..\Seguridad\Seguridad.csproj" al proyecto.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi> cd ..
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> cd .\Persistencia\
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia> dotnet add reference ..\Dominio\
Se ha agregado la referencia "..\Dominio\Dominio.csproj" al proyecto.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia> cd ..
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> cd .\Seguridad\
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad> dotnet add reference ..\Aplicacion\
Se ha agregado la referencia "..\Aplicacion\Aplicacion.csproj" al proyecto.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad> cd ..
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> dotnet sln list
Proyectos
---------
Aplicacion\Aplicacion.csproj
Dominio\Dominio.csproj
Persistencia\Persistencia.csproj
Seguridad\Seguridad.csproj
skeletonEsApi\skeletonEsApi.csproj
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> code .

PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> cd .\Dominio\
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio> dotnet add package Microsoft.EntityFrameworkCore --version 7.0.10
  Determinando los proyectos que se van a restaurar...
  Writing C:\Users\karen\AppData\Local\Temp\tmp4E0D.tmp
info : X.509 certificate chain validation will use the default trust store selected by .NET for code signing.
info : X.509 certificate chain validation will use the default trust store selected by .NET for timestamping.
info : Agregando PackageReference para el paquete "Microsoft.EntityFrameworkCore" al proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj".
info : Restaurando paquetes para C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj...
info : El paquete "Microsoft.EntityFrameworkCore" es compatible con todos los marcos de trabajo especificados del proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj".
info : Se agregó PackageReference para la versión "7.0.10" del paquete "Microsoft.EntityFrameworkCore" al archivo "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj".
info : Generación de archivo MSBuild C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\obj\Dominio.csproj.nuget.g.props.
info : Generación de archivo MSBuild C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\obj\Dominio.csproj.nuget.g.targets.
info : Escribiendo el archivo de recursos en el disco. Ruta de acceso: C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\obj\project.assets.json
log  : Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj (en 328 ms).
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio> dotnet add package itext7.pdfhtml --version 5.0.1
  Determinando los proyectos que se van a restaurar...
  Writing C:\Users\karen\AppData\Local\Temp\tmp4F0.tmp
info : X.509 certificate chain validation will use the default trust store selected by .NET for code signing.
info : X.509 certificate chain validation will use the default trust store selected by .NET for timestamping.
info : Agregando PackageReference para el paquete "itext7.pdfhtml" al proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj".
info : Restaurando paquetes para C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj...
info : El paquete "itext7.pdfhtml" es compatible con todos los marcos de trabajo especificados del proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj".
info : Se agregó PackageReference para la versión "5.0.1" del paquete "itext7.pdfhtml" al archivo "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj".
info : Escribiendo el archivo de recursos en el disco. Ruta de acceso: C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\obj\project.assets.json
log  : Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj (en 1,02 sec).
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio> dotnet add package FluentValidation.AspNetCore --version 11.3.0
  Determinando los proyectos que se van a restaurar...
  Writing C:\Users\karen\AppData\Local\Temp\tmpA130.tmp
info : X.509 certificate chain validation will use the default trust store selected by .NET for code signing.
info : X.509 certificate chain validation will use the default trust store selected by .NET for timestamping.
info : Agregando PackageReference para el paquete "FluentValidation.AspNetCore" al proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj".
info : Restaurando paquetes para C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj...
info : El paquete "FluentValidation.AspNetCore" es compatible con todos los marcos de trabajo especificados del proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj".
info : Se agregó PackageReference para la versión "11.3.0" del paquete "FluentValidation.AspNetCore" al archivo "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj".
info : Escribiendo el archivo de recursos en el disco. Ruta de acceso: C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\obj\project.assets.json
log  : Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio\Dominio.csproj (en 376 ms).
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Dominio> cd ..

 cd .\Persistencia\
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia> dotnet add package Microsoft.EntityFrameworkCore --version 7.0.10
  Determinando los proyectos que se van a restaurar...
  Writing C:\Users\karen\AppData\Local\Temp\tmpF80.tmp
info : X.509 certificate chain validation will use the default trust store selected by .NET for code signing.
info : X.509 certificate chain validation will use the default trust store selected by .NET for timestamping.
info : Agregando PackageReference para el paquete "Microsoft.EntityFrameworkCore" al proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\Persistencia.csproj".
info : Restaurando paquetes para C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\Persistencia.csproj...
info : El paquete "Microsoft.EntityFrameworkCore" es compatible con todos los marcos de trabajo especificados del proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\Persistencia.csproj".
info : Se agregó PackageReference para la versión "7.0.10" del paquete "Microsoft.EntityFrameworkCore" al archivo "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\Persistencia.csproj".
info : Generación de archivo MSBuild C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\obj\Persistencia.csproj.nuget.g.props.
info : Generación de archivo MSBuild C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\obj\Persistencia.csproj.nuget.g.targets.
info : Escribiendo el archivo de recursos en el disco. Ruta de acceso: C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\obj\project.assets.json
log  : Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\Persistencia.csproj (en 554 ms).
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia> dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0
  Determinando los proyectos que se van a restaurar...
  Writing C:\Users\karen\AppData\Local\Temp\tmp5A64.tmp
info : X.509 certificate chain validation will use the default trust store selected by .NET for code signing.
info : X.509 certificate chain validation will use the default trust store selected by .NET for timestamping.
info : Agregando PackageReference para el paquete "Pomelo.EntityFrameworkCore.MySql" al proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\Persistencia.csproj".
info : Restaurando paquetes para C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\Persistencia.csproj...
info : El paquete "Pomelo.EntityFrameworkCore.MySql" es compatible con todos los marcos de trabajo especificados del proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\Persistencia.csproj".
info : Se agregó PackageReference para la versión "7.0.0" del paquete "Pomelo.EntityFrameworkCore.MySql" al archivo "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\Persistencia.csproj".
info : Escribiendo el archivo de recursos en el disco. Ruta de acceso: C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\obj\project.assets.json
log  : Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Persistencia\Persistencia.csproj (en 495 ms).

cd ..

PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> cd .\Seguridad\
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad> dotnet add package System.IdentityModel.Tokens.Jwt --version 6.32.2
  Determinando los proyectos que se van a restaurar...
  Writing C:\Users\karen\AppData\Local\Temp\tmpECBC.tmp
info : X.509 certificate chain validation will use the default trust store selected by .NET for code signing.
info : X.509 certificate chain validation will use the default trust store selected by .NET for timestamping.
info : Agregando PackageReference para el paquete "System.IdentityModel.Tokens.Jwt" al proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\Seguridad.csproj".
info : Restaurando paquetes para C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\Seguridad.csproj...
info : El paquete "System.IdentityModel.Tokens.Jwt" es compatible con todos los marcos de trabajo especificados del proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\Seguridad.csproj".
info : Se agregó PackageReference para la versión "6.32.2" del paquete "System.IdentityModel.Tokens.Jwt" al archivo "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\Seguridad.csproj".
info : Generación de archivo MSBuild C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\obj\Seguridad.csproj.nuget.g.props.
info : Generación de archivo MSBuild C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\obj\Seguridad.csproj.nuget.g.targets.info : Escribiendo el archivo de recursos en el disco. Ruta de acceso: C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\obj\project.assets.json
log  : Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\Seguridad.csproj (en 586 ms).
PS C:\cd ..                   umentos\NetCoreProjects\skeletonWebApiEs\Seguridad>
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs>

PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> cd .\Seguridad\
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad> dotnet add package System.IdentityModel.Tokens.Jwt --version 6.32.2
  Determinando los proyectos que se van a restaurar...
  Writing C:\Users\karen\AppData\Local\Temp\tmpECBC.tmp
info : X.509 certificate chain validation will use the default trust store selected by .NET for code signing.
info : X.509 certificate chain validation will use the default trust store selected by .NET for timestamping.
info : Agregando PackageReference para el paquete "System.IdentityModel.Tokens.Jwt" al proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\Seguridad.csproj".
info : Restaurando paquetes para C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\Seguridad.csproj...
info : El paquete "System.IdentityModel.Tokens.Jwt" es compatible con todos los marcos de trabajo especificados del proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\Seguridad.csproj".
info : Se agregó PackageReference para la versión "6.32.2" del paquete "System.IdentityModel.Tokens.Jwt" al archivo "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\Seguridad.csproj".
info : Generación de archivo MSBuild C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\obj\Seguridad.csproj.nuget.g.props.
info : Generación de archivo MSBuild C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\obj\Seguridad.csproj.nuget.g.targets.info : Escribiendo el archivo de recursos en el disco. Ruta de acceso: C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\obj\project.assets.json
log  : Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\Seguridad\Seguridad.csproj (en 586 ms).
PS C:\cd ..                   umentos\NetCoreProjects\skeletonWebApiEs\Seguridad>
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs> cd .\skeletonEsApi\
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi> dotnet add package AspNetCoreRateLimit --version 5.0.0
  Determinando los proyectos que se van a restaurar...
  Writing C:\Users\karen\AppData\Local\Temp\tmp5D7E.tmp
info : X.509 certificate chain validation will use the default trust store selected by .NET for code signing.
info : X.509 certificate chain validation will use the default trust store selected by .NET for timestamping.
info : Agregando PackageReference para el paquete "AspNetCoreRateLimit" al proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Restaurando paquetes para C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj...
info : El paquete "AspNetCoreRateLimit" es compatible con todos los marcos de trabajo especificados del proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Se agregó PackageReference para la versión "5.0.0" del paquete "AspNetCoreRateLimit" al archivo "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Generación de archivo MSBuild C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\obj\skeletonEsApi.csproj.nuget.g.props.
info : Generación de archivo MSBuild C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\obj\skeletonEsApi.csproj.nuget.g.targets.
info : Escribiendo el archivo de recursos en el disco. Ruta de acceso: C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\obj\project.assets.json
log  : Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj (en 550 ms).
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi> dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1
  Determinando los proyectos que se van a restaurar...
  Writing C:\Users\karen\AppData\Local\Temp\tmpBE3B.tmp
info : X.509 certificate chain validation will use the default trust store selected by .NET for code signing.
info : X.509 certificate chain validation will use the default trust store selected by .NET for timestamping.
info : Agregando PackageReference para el paquete "AutoMapper.Extensions.Microsoft.DependencyInjection" al proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Restaurando paquetes para C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj...
info : El paquete "AutoMapper.Extensions.Microsoft.DependencyInjection" es compatible con todos los marcos de trabajo especificados del proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Se agregó PackageReference para la versión "12.0.1" del paquete "AutoMapper.Extensions.Microsoft.DependencyInjection" al archivo "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Escribiendo el archivo de recursos en el disco. Ruta de acceso: C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\obj\project.assets.json
log  : Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj (en 430 ms).
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi> dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 7.0.10
  Determinando los proyectos que se van a restaurar...
  Writing C:\Users\karen\AppData\Local\Temp\tmp4C91.tmp
info : X.509 certificate chain validation will use the default trust store selected by .NET for code signing.
info : X.509 certificate chain validation will use the default trust store selected by .NET for timestamping.
info : Agregando PackageReference para el paquete "Microsoft.AspNetCore.Authentication.JwtBearer" al proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Restaurando paquetes para C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj...
info : El paquete "Microsoft.AspNetCore.Authentication.JwtBearer" es compatible con todos los marcos de trabajo especificados del proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Se agregó PackageReference para la versión "7.0.10" del paquete "Microsoft.AspNetCore.Authentication.JwtBearer" al archivo "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Escribiendo el archivo de recursos en el disco. Ruta de acceso: C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\obj\project.assets.json
log  : Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj (en 557 ms).
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi> dotnet add package Microsoft.AspNetCore.Mvc.Versioning --version 5.1.0
  Determinando los proyectos que se van a restaurar...
  Writing C:\Users\karen\AppData\Local\Temp\tmp1B99.tmp
info : X.509 certificate chain validation will use the default trust store selected by .NET for code signing.
info : X.509 certificate chain validation will use the default trust store selected by .NET for timestamping.
info : Agregando PackageReference para el paquete "Microsoft.AspNetCore.Mvc.Versioning" al proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Restaurando paquetes para C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj...
info : El paquete "Microsoft.AspNetCore.Mvc.Versioning" es compatible con todos los marcos de trabajo especificados del proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Se agregó PackageReference para la versión "5.1.0" del paquete "Microsoft.AspNetCore.Mvc.Versioning" al archivo "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Escribiendo el archivo de recursos en el disco. Ruta de acceso: C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\obj\project.assets.json
log  : Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj (en 600 ms).
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi> dotnet add package Microsoft.AspNetCore.OpenApi --version 7.0.10
  Determinando los proyectos que se van a restaurar...
  Writing C:\Users\karen\AppData\Local\Temp\tmpD880.tmp
info : X.509 certificate chain validation will use the default trust store selected by .NET for code signing.
info : X.509 certificate chain validation will use the default trust store selected by .NET for timestamping.
info : Agregando PackageReference para el paquete "Microsoft.AspNetCore.OpenApi" al proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Restaurando paquetes para C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj...
info : El paquete "Microsoft.AspNetCore.OpenApi" es compatible con todos los marcos de trabajo especificados del proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Se actualizó PackageReference para la versión "7.0.10" del paquete "Microsoft.AspNetCore.OpenApi" en el archivo "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Escribiendo el archivo de recursos en el disco. Ruta de acceso: C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\obj\project.assets.json
log  : Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj (en 666 ms).
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi> dotnet add package Microsoft.AspNetCore.OpenApi --version 7.0.10
  Determinando los proyectos que se van a restaurar...
  Writing C:\Users\karen\AppData\Local\Temp\tmpB5FF.tmp
info : X.509 certificate chain validation will use the default trust store selected by .NET for code signing.
info : X.509 certificate chain validation will use the default trust store selected by .NET for timestamping.
info : Agregando PackageReference para el paquete "Microsoft.AspNetCore.OpenApi" al proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Restaurando paquetes para C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj...
info : El paquete "Microsoft.AspNetCore.OpenApi" es compatible con todos los marcos de trabajo especificados del proyecto "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : Se actualizó PackageReference para la versión "7.0.10" del paquete "Microsoft.AspNetCore.OpenApi" en el archivo "C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj".
info : El archivo de recursos no ha cambiado, así que se omitirá su escritura. Ruta de acceso: C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\obj\project.assets.json
log  : Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi\skeletonEsApi.csproj (en 553 ms).
PS C:\Usercd ..en\OneDrive\Documentos\NetCoreProjects\skeletonWebApiEs\skeletonEsApi>