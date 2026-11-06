# LabCapas — Aplicación de escritorio en C# con arquitectura por capas y MVP

**Universidad Tecnológica de Panamá (UTP)**  
**Facultad de Ingeniería de Sistemas Computacionales**  
**Asignatura:** Herramientas de la Programación Aplicada III (.NET)  
**Grupo:** 1IL133  
**Docente:** Ing. Irina Fong  
**Autora:** Aimee Matías  
**Fecha:** 6 de noviembre de 2026

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
| .NET Framework | Plataforma de ejecución | **4.7.2** |
| Windows Forms | Interfaz de escritorio | Incluido en .NET Framework |
| MetroModernUI / MetroFramework | Estilo de formularios y controles | **1.4.0.0** |
| FontAwesome.Sharp | Íconos | **6.6.0** |
| MySql.Data | Acceso a MySQL | **26.7.0** (paquete registrado en el proyecto) |
| MySQL | Base de datos relacional | Versión del servidor por documentar |
| Visual Studio | Entorno de desarrollo | Versión instalada por documentar |

Las versiones de bibliotecas se tomaron de los archivos de proyecto y de NuGet del ZIP compartido.

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

Los archivos de `MVP/` y los servicios de hash corresponden a los cambios realizados después del último ZIP compartido y deben estar incluidos en la versión final del repositorio.

### Flujo de inicio de sesión con MVP

```text
frmLogin (Vista / ILoginView)
             |
             v
LoginPresenter (Presentador)
             |
             v
N_Usuario (Negocio)
             |
             v
D_Usuario (Datos)
             |
             v
MySQL: productos.sp_ValidarLoginHash
             |
             v
frmPrincipal (sesión del usuario)
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

**Nota de seguridad:** la implementación del laboratorio utiliza SHA-512 sin sal individual por compatibilidad con la base existente. Para uso en producción se recomienda migrar a un algoritmo especializado en contraseñas, como Argon2id, bcrypt o PBKDF2, con una estrategia de migración de hashes. No publicar contraseñas, cadenas de conexión con secretos ni datos reales de usuarios.

## Interfaz y funcionalidades

- Formulario de inicio de sesión con validación de campos.
- Mensajes para credenciales incorrectas y fallas de conexión.
- Interfaz principal con menú lateral y opciones **Productos, Ventas, Clientes, Proveedores, Compras y Misceláneos**.
- Reloj digital actualizado cada segundo.
- Usuario autenticado identificado en pantalla y en la parte inferior del menú lateral.
- Controles para expandir/contraer el menú y administrar la ventana.

### Captura de la interfaz principal

![Interfaz principal de LabCapas: menú lateral, reloj y usuario conectado](images/principal.png)

*Pantalla de `frmPrincipal` que muestra el menú lateral, la hora y la sesión del usuario.*

### Capturas adicionales

Agregar aquí, si se desea documentar todas las validaciones, imágenes del formulario de inicio de sesión y de los mensajes por campos vacíos o credenciales incorrectas.

## Requisitos para ejecutar

- Windows con **.NET Framework 4.7.2** disponible.
- Visual Studio compatible con proyectos C# de .NET Framework y Windows Forms.
- MySQL Server y MySQL Workbench (para administrar la base y sus permisos).
- Paquetes NuGet restaurados según los archivos `packages.config`.
- Base de datos `productos`, tabla `usuarios` y procedimiento `sp_ValidarLoginHash` configurados previamente.
- Cuenta de MySQL exclusiva para la aplicación, con permisos mínimos.

> El ZIP revisado **no incluye un script de creación y carga de la base de datos**. Para instalar el proyecto en otro equipo, debe proporcionarse por separado un script SQL seguro, sin contraseñas reales.

## Instalación y ejecución

1. Clonar el repositorio:

   ```bash
   git clone https://github.com/ajmatias89/LabCapas.git
   ```

2. Abrir `LabCapas.slnx` en Visual Studio.
3. Restaurar los paquetes NuGet de la solución.
4. Crear o importar el esquema MySQL `productos`, con la tabla `usuarios` y el procedimiento almacenado de autenticación.
5. Crear un usuario MySQL dedicado con los privilegios mínimos requeridos.
6. Configurar la cadena de conexión **localmente**, utilizando ese usuario, sin subir credenciales al repositorio. Si la versión del proyecto mantiene la cadena en `D_Conexion`, trasladar el secreto a una configuración local excluida de Git antes de publicar.
7. Seleccionar **Presentacion** como proyecto de inicio.
8. Compilar con **Build → Build Solution** y ejecutar con **F5**.
9. Iniciar sesión con una cuenta de prueba previamente creada en la base de datos.

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

## Validaciones y pruebas manuales

| Prueba | Resultado esperado |
|---|---|
| Usuario vacío o contraseña vacía | Mostrar mensaje de validación |
| Credenciales incorrectas | No permitir acceso y mostrar error |
| Credenciales válidas | Abrir `frmPrincipal` |
| Inicio de sesión correcto | Mostrar el usuario conectado |
| Aplicación abierta durante varios segundos | Actualizar el reloj automáticamente |
| Uso del menú lateral | Permitir expandirlo o contraerlo |
| Cuenta MySQL con permisos limitados | Permitir únicamente las operaciones autorizadas |

## Autoría

**Aimee Matías**  
Universidad Tecnológica de Panamá — Facultad de Ingeniería de Sistemas Computacionales  
Herramientas de la Programación Aplicada III (.NET), grupo 1IL133  
**Fecha:** noviembre de 2026.

---

*Proyecto académico desarrollado con fines educativos para practicar arquitectura por capas, patrón MVP, conexión a MySQL y controles de seguridad de autenticación.*
