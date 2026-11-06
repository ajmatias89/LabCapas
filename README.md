# LabCapas — Aplicación de escritorio en C# con arquitectura por capas y MVP

**Universidad Tecnológica de Panamá (UTP)**  
**Facultad de Ingeniería de Sistemas Computacionales**  
**Asignatura:** Herramientas de la Programación Aplicada III (.NET)  
**Grupo:** 1IL133  
**Docente:** Ing. Irina Fong  
**Autora:** Aimee Matias  
**Fecha:** 9 de noviembre de 2026

## Descripción

**LabCapas** es una aplicación de escritorio desarrollada con **C# y Windows Forms** para practicar la separación de responsabilidades mediante una **arquitectura de cuatro capas** y el patrón **Modelo–Vista–Presentador (MVP)** aplicado al inicio de sesión.

El proyecto utiliza una base de datos MySQL denominada `productos`, autenticación mediante un procedimiento almacenado y una interfaz principal con menú lateral, reloj en tiempo real e identificación del usuario autenticado.

> **Alcance:** el proyecto es un laboratorio de arquitectura y autenticación. Los apartados del menú (Productos, Ventas, Clientes, Proveedores, Compras y Misceláneos) forman parte de la navegación; su presencia no implica que todos los módulos tengan operaciones completas de gestión.

## Objetivos

- Organizar el código en capas de presentación, negocio, datos y entidades.
- Aplicar MVP para separar la vista del control del inicio de sesión.
- Definir dos contratos independientes para generar y verificar hashes de contraseñas.
- Acceder a MySQL mediante un usuario de aplicación con permisos limitados.
- Mostrar una interfaz con menú lateral, hora actual y datos del usuario conectado.

## Tecnologías utilizadas

| Tecnología | Uso | Versión / referencia |
|---|---|---|
| C# | Lenguaje de programación | Proyecto sobre .NET Framework |
| .NET Framework | Plataforma de ejecución 
| Windows Forms | Interfaz de escritorio | Incluido en .NET Framework |
| MetroModernUI / MetroFramework | Estilo de formularios y controles 
| FontAwesome.Sharp | Íconos 
| MySql.Data | Acceso a MySQL 
| MySQL | Base de datos relacional | Versión del servidor por documentar |
| Visual Studio | Entorno de desarrollo | Versión instalada por documentar |


## Arquitectura

El proyecto se organiza en cuatro capas:

```text
LabCapas/
├── Datos/          # Conexión a MySQL y consultas/procedimientos
├── Entidades/      # Clases que representan los datos (E_Usuario)
├── Negocio/        # Reglas de negocio (N_Usuario), interfaces y HashService
├── Presentacion/   # Formularios Windows Forms y patrón MVP
│   └── MVP/        # ILoginView y LoginPresenter
├── Iconos/         # Recursos visuales
└── README.md
```



- **Vista:** obtiene las credenciales y presenta mensajes.
- **Presentador:** valida campos, coordina la autenticación y comunica el resultado a la vista.
- **Negocio:** expone operaciones del usuario y contratos de hashing.
- **Datos:** ejecuta el procedimiento almacenado utilizando `MySql.Data`.
- **Entidades:** define `E_Usuario` para transportar los datos de la sesión.

## Seguridad y autenticación

La capa de negocio incluye los contratos `IHashService` y `IVerificarHashService`, implementados por `HashService`.

El procedimiento `sp_ValidarLoginHash` del esquema `productos` compara la contraseña introducida con el valor almacenado mediante:

```sql
AND dsPassword = UNHEX(SHA2(_dsPassword, 512))
```

La cuenta dedicada de MySQL debe disponer únicamente de los permisos necesarios para iniciar sesión, preferiblemente `EXECUTE` sobre el procedimiento específico cuando su configuración de seguridad lo permita. No se requieren permisos administrativos de MySQL para operar la aplicación.


## Interfaz y funcionalidades

- Formulario de inicio de sesión con validación de campos.
- Mensajes para credenciales incorrectas y fallas de conexión.
- Interfaz principal con menú lateral y opciones **Productos, Ventas, Clientes, Proveedores, Compras y Misceláneos**.
- Reloj digital actualizado cada segundo.
- Usuario autenticado identificado en pantalla y en la parte inferior del menú lateral.
- Controles para expandir/contraer el menú y administrar la ventana.

### Capturas


frmLogin

<img width="598" height="410" alt="image" src="https://github.com/user-attachments/assets/420ea3fd-1833-4c3c-a193-3caa0730e661" />




frmLogin al ingresar credenciales incorrectas

<img width="600" height="402" alt="image" src="https://github.com/user-attachments/assets/50897a76-1165-4cb5-9690-70445784a723" />




frmPrincipal al ingresar correctamente

<img width="1915" height="1007" alt="image" src="https://github.com/user-attachments/assets/848599c0-651c-46b4-8a74-94bd8a4ceb8f" />




frmProductos al ingresar a la sección Productos del frmPrincipal

<img width="742" height="455" alt="image" src="https://github.com/user-attachments/assets/ec891a4f-fc7e-4a61-a3ac-8699734b1755" />




frmPrincipal con pestaña oculta

<img width="822" height="403" alt="image" src="https://github.com/user-attachments/assets/cf6d97ee-b25a-49bf-a48d-e9ddda3f547a" />









## Requisitos para ejecutar

- Windows con **.NET Framework 4.7.2** disponible.
- Visual Studio compatible con proyectos C# de .NET Framework y Windows Forms.
- MySQL Server y MySQL Workbench (para administrar la base y sus permisos).
- Paquetes NuGet restaurados según los archivos `packages.config`.
- Base de datos `productos`, tabla `usuarios` y procedimiento `sp_ValidarLoginHash` configurados previamente.
- Cuenta de MySQL exclusiva para la aplicación, con permisos mínimos.




## Controles utilizados

| Control | Función |
|---|---|
| `MetroForm` | Ventanas de inicio de sesión e interfaz principal |
| `TextBox` / controles Metro de entrada | Captura de usuario y contraseña |
| `Button` | Inicio de sesión y navegación |
| `Panel` / `MetroPanel` | Organización del menú lateral y área central |
| `Label` / `MetroLabel` | Mensajes, hora y datos de la sesión |
| `PictureBox` | Íconos y controles gráficos |
| `Timer` | Actualización del reloj cada segundo |
| `MetroMessageBox` | Mensajes de validación |



## Autoría

**Aimee Matias**  
Universidad Tecnológica de Panamá — Facultad de Ingeniería de Sistemas Computacionales  
Herramientas de la Programación Aplicada III (.NET), grupo 1IL133  
**Fecha:** 9 noviembre de 2026.


## Fuentes 

Videos de YouTube utilizados para el desarrollo 

- https://www.youtube.com/watch?v=y1jftnTaTXU
- https://www.youtube.com/watch?v=rX2AmgIqmy0&t=3171s

---

*Proyecto académico desarrollado con fines educativos para practicar arquitectura por capas, patrón MVP, conexión a MySQL y controles de seguridad de autenticación.*
