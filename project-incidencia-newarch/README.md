# incidenciaNewArch
  hacer proyecto hasta paginacion, act 22/08

  
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> dotnet new sln
La plantilla "Archivo de la solución" se creó correctamente.

PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> dotnet new classlib -o Dominio
La plantilla "Biblioteca de clases" se creó correctamente.

Procesando acciones posteriores a la creación...
Restaurando C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch\Dominio\Dominio.csproj:
  Determinando los proyectos que se van a restaurar...
  Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch\Dominio\Dominio.csproj (en 48 ms).
Restauración realizada correctamente.


PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> dotnet new classlib -o Persistencia
La plantilla "Biblioteca de clases" se creó correctamente.

Procesando acciones posteriores a la creación...
Restaurando C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch\Persistencia\Persistencia.csproj:
  Determinando los proyectos que se van a restaurar...
  Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch\Persistencia\Persistencia.csproj (en 47 ms).
Restauración realizada correctamente.


PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> dotnet new classlib -o Aplicacion
La plantilla "Biblioteca de clases" se creó correctamente.

Procesando acciones posteriores a la creación...
Restaurando C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch\Aplicacion\Aplicacion.csproj:
  Determinando los proyectos que se van a restaurar...
  Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch\Aplicacion\Aplicacion.csproj (en 46 ms).
Restauración realizada correctamente.


PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> dotnet new webapi -o ApiIncidenciaNewK
La plantilla "ASP.NET Core Web API" se creó correctamente.

Procesando acciones posteriores a la creación...
Restaurando C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch\ApiIncidenciaNewK\ApiIncidenciaNewK.csproj:
  Determinando los proyectos que se van a restaurar...
  Se ha restaurado C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch\ApiIncidenciaNewK\ApiIncidenciaNewK.csproj (en 153 ms).
Restauración realizada correctamente.


PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> dir


    Directorio: C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch


Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
d-----      23/08/2023  6:34 a. m.                ApiIncidenciaNewK
d-----      23/08/2023  6:34 a. m.                Aplicacion
d-----      23/08/2023  6:33 a. m.                Dominio
d-----      23/08/2023  6:33 a. m.                Persistencia
-a----      23/08/2023  6:33 a. m.            441 incidenciaNewArch.sln
-a---l      22/08/2023  8:45 a. m.             67 README.md


PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> dotnet dln list
No se pudo ejecutar porque no se encontró el comando o el archivo especificado.
Algunas de las posibles causas son :
  * Escribió mal un comando dotnet integrado.
  * Pretendía ejecutar un programa .NET, pero dotnet-dln no existe.
  * Pretendía ejecutar una herramienta global, pero no se encontró ningún ejecutable con prefijo dotnet con este nombre en PATH.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> dotnet sln list
No se han encontrado proyectos en la solución.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> dotnet sln add .\ApiIncidenciaNewK\
Se ha agregado el proyecto "ApiIncidenciaNewK\ApiIncidenciaNewK.csproj" a la solución.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> dotnet sln add .\Aplicacion\
Se ha agregado el proyecto "Aplicacion\Aplicacion.csproj" a la solución.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> dotnet sln add .\Dominio\
Se ha agregado el proyecto "Dominio\Dominio.csproj" a la solución.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> dotnet sln add .\Persistencia\
Se ha agregado el proyecto "Persistencia\Persistencia.csproj" a la solución.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> dotnet sln list
Proyectos
---------
ApiIncidenciaNewK\ApiIncidenciaNewK.csproj
Aplicacion\Aplicacion.csproj
Dominio\Dominio.csproj
Persistencia\Persistencia.csproj
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> cd .\Aplicacion\
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch\Aplicacion> dotnet add reference ..\Dominio\
Se ha agregado la referencia "..\Dominio\Dominio.csproj" al proyecto.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch\Aplicacion> dotnet add reference ..\Persistencia\
Se ha agregado la referencia "..\Persistencia\Persistencia.csproj" al proyecto.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch\Aplicacion> cd..
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> cd .\ApiIncidenciaNewK\
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch\ApiIncidenciaNewK> dotnet add reference ..\Aplicacion\
Se ha agregado la referencia "..\Aplicacion\Aplicacion.csproj" al proyecto.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch\ApiIncidenciaNewK> cd ..
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> cd .\Persistencia\
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch\Persistencia> dotnet add reference ..\Dominio\
Se ha agregado la referencia "..\Dominio\Dominio.csproj" al proyecto.
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch\Persistencia> cd ..
PS C:\Users\karen\OneDrive\Documentos\NetCoreProjects\incidenciaNewArch> code .
