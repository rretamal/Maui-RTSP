# MAUI RTSP Camera Viewer

[English](#english) | [Español](#español)

---

## English

### Overview

A .NET MAUI application for streaming RTSP cameras with real-time video playback capabilities. This project demonstrates how to integrate RTSP streaming functionality into cross-platform mobile applications using .NET MAUI.

### Features

- **Real-time RTSP streaming** - Connect to IP cameras and view live feeds
- **Cross-platform support** - Works on Android and iOS
- **Custom CameraView control** - Reusable component for camera integration
- **Authentication support** - Username/password authentication for secure cameras
- **Clean architecture** - Built following SOLID principles and clean architecture patterns

### Technology Stack

- **.NET MAUI 8.0** - Cross-platform framework
- **AndroidX Media3 ExoPlayer** - For video streaming
- **Custom Android Library** - Native RTSP client integration
- **MVVM Pattern** - Clean separation of concerns

### Project Structure

```
Maui-RTSP/
├── Maui.Rtsp/                 # Main MAUI application
│   ├── Controls/             # Custom controls (CameraView)
│   ├── Views/                # UI pages
│   ├── Handlers/             # Platform-specific handlers
│   └── Resources/            # App resources
├── Maui.Rtsp.AndroidLib/     # Android-specific library
│   └── library-client-rtsp.aar # Native RTSP client
└── Maui.Rtsp.sln             # Solution file
```

### Getting Started

1. **Prerequisites**

   - Visual Studio 2022 with .NET MAUI workload
   - .NET 8.0 SDK
   - Android SDK (for Android development)

2. **Clone and Build**

   ```bash
   git clone <repository-url>
   cd Maui-RTSP
   dotnet restore
   dotnet build
   ```

3. **Run the Application**
   - Open the solution in Visual Studio
   - Select your target platform (Android/iOS)
   - Press F5 to run

### Usage

1. Enter your RTSP camera URL (e.g., `rtsp://192.168.100.32`)
2. Provide username and password if required
3. Click "Check device" to test the connection
4. The camera feed will display in the custom CameraView control

### Working Example

See this project in action with the **ReCam Viewer** app available on Google Play:
[![ReCam Viewer on Google Play](https://play.google.com/intl/en_us/badges/static/images/badges/en_badge_web_generic.png)](https://play.google.com/store/apps/details?id=com.recam.droid)

The ReCam Viewer app demonstrates the full capabilities of RTSP streaming with features like:

- Real-time streaming
- Automatic camera discovery
- Zoom & snapshots
- Floating overlay mode
- Camera organization and customization

### Related Resources

📖 **Original Article**: [Viewing an RTSP Stream in .NET MAUI](https://medium.com/c-sharp-programming/viewing-an-rtsp-stream-in-net-maui-6948d30a2b21) - Detailed implementation guide and technical insights

### Architecture

This project follows clean architecture principles:

- **Dependency Injection** - All services are injected
- **SOLID Principles** - Clean, maintainable code structure
- **Composition over Inheritance** - Flexible component design
- **Self-documenting Code** - Clear naming conventions

### Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes following the established patterns
4. Submit a pull request

### License

This project is licensed under the MIT License.

---

## Español

### Descripción General

Una aplicación .NET MAUI para transmitir cámaras RTSP con capacidades de reproducción de video en tiempo real. Este proyecto demuestra cómo integrar funcionalidad de transmisión RTSP en aplicaciones móviles multiplataforma usando .NET MAUI.

### Características

- **Transmisión RTSP en tiempo real** - Conecta a cámaras IP y visualiza transmisiones en vivo
- **Soporte multiplataforma** - Funciona en Android e iOS
- **Control CameraView personalizado** - Componente reutilizable para integración de cámaras
- **Soporte de autenticación** - Autenticación de usuario/contraseña para cámaras seguras
- **Arquitectura limpia** - Construido siguiendo principios SOLID y patrones de arquitectura limpia

### Stack Tecnológico

- **.NET MAUI 8.0** - Framework multiplataforma
- **AndroidX Media3 ExoPlayer** - Para transmisión de video
- **Biblioteca Android Personalizada** - Integración de cliente RTSP nativo
- **Patrón MVVM** - Separación limpia de responsabilidades

### Estructura del Proyecto

```
Maui-RTSP/
├── Maui.Rtsp/                 # Aplicación MAUI principal
│   ├── Controls/             # Controles personalizados (CameraView)
│   ├── Views/                # Páginas de UI
│   ├── Handlers/             # Manejadores específicos de plataforma
│   └── Resources/            # Recursos de la aplicación
├── Maui.Rtsp.AndroidLib/     # Biblioteca específica de Android
│   └── library-client-rtsp.aar # Cliente RTSP nativo
└── Maui.Rtsp.sln             # Archivo de solución
```

### Comenzando

1. **Prerrequisitos**

   - Visual Studio 2022 con carga de trabajo .NET MAUI
   - SDK .NET 8.0
   - SDK de Android (para desarrollo Android)

2. **Clonar y Compilar**

   ```bash
   git clone <url-del-repositorio>
   cd Maui-RTSP
   dotnet restore
   dotnet build
   ```

3. **Ejecutar la Aplicación**
   - Abre la solución en Visual Studio
   - Selecciona tu plataforma objetivo (Android/iOS)
   - Presiona F5 para ejecutar

### Uso

1. Ingresa la URL de tu cámara RTSP (ej., `rtsp://192.168.100.32`)
2. Proporciona usuario y contraseña si es requerido
3. Haz clic en "Check device" para probar la conexión
4. La transmisión de la cámara se mostrará en el control CameraView personalizado

### Ejemplo Funcionando

Ve este proyecto en acción con la aplicación **ReCam Viewer** disponible en Google Play:
[![ReCam Viewer en Google Play](https://play.google.com/intl/en_us/badges/static/images/badges/en_badge_web_generic.png)](https://play.google.com/store/apps/details?id=com.recam.droid)

La aplicación ReCam Viewer demuestra las capacidades completas de transmisión RTSP con características como:

- Transmisión en tiempo real
- Descubrimiento automático de cámaras
- Zoom y capturas de pantalla
- Modo de superposición flotante
- Organización y personalización de cámaras

### Recursos Relacionados

📖 **Artículo Original**: [Viewing an RTSP Stream in .NET MAUI](https://medium.com/c-sharp-programming/viewing-an-rtsp-stream-in-net-maui-6948d30a2b21) - Guía detallada de implementación e información técnica

### Arquitectura

Este proyecto sigue principios de arquitectura limpia:

- **Inyección de Dependencias** - Todos los servicios son inyectados
- **Principios SOLID** - Estructura de código limpia y mantenible
- **Composición sobre Herencia** - Diseño de componentes flexible
- **Código Autodocumentado** - Convenciones de nomenclatura claras

### Contribuir

1. Haz fork del repositorio
2. Crea una rama de características
3. Realiza tus cambios siguiendo los patrones establecidos
4. Envía un pull request

### Licencia

Este proyecto está licenciado bajo la Licencia MIT.
