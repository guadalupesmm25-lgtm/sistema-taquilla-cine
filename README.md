# Sistema de Venta de Boletos y Dulcería (C# & .NET)

## 📝 Descripción
Aplicación de consola desarrollada en **C# (.NET)** que simula de manera integral el sistema de punto de venta (POS) para una cadena de cines. El proyecto aplica principios de **Programación Orientada a Objetos (POO)** como herencia y encapsulamiento para gestionar de forma modular la selección de salas, cartelera, dulcería y facturación.

## 🎯 Objetivo Principal
Proporcionar una interfaz interactiva de consola que permita a los usuarios autenticarse, elegir un complejo cinematográfico, seleccionar películas con verificación de inventario/disponibilidad, personalizar productos en dulcería y generar recibos detallados con cálculo automático de impuestos (16% IVA).

## 🏗️ Arquitectura y Estructura de Clases
El sistema está estructurado mediante una jerarquía de clases para maximizar la reutilización del código:

- **`Usuario` (Clase Base):**
  - **Atributos:** `User_Name`, `User_Password`, `Cinema`, `opcion`, `cicle`.
  - **Métodos:** `Usuarios()` (solicitud de credenciales y selección de sucursal), `getUsers_Info()` (retorno de saludo y contexto del complejo seleccionado).
  - **Lógica:** Autenticación básica y control de navegación mediante bucles de validación.

- **`Movie_Menu` (Hereda de `Usuario`):**
  - **Atributos:** `opcionmov`, `quantity` (control de inventario), `cantidad`, `sala`, `precio`, `pelicula_selec`, `idioma`.
  - **Métodos:** `Movies()` (despliegue de cartelera, validación de cupo y cálculo de costos con IVA), `getMovTicket()` (generación del desglose de boletos).

- **`Food_Menu` (Hereda de `Usuario`):**
  - **Atributos:** `menu`, `seleccion`, `sabor_refresco`, `sabor_icee`, `total`.
  - **Métodos:** `Foods()` (gestión de combos de dulcería y selección de sabores), `getFoodTicket()` (emisión del ticket de dulcería).

## 🛠️ Competencias Adquiridas
- **Programación Orientada a Objetos (POO):** Diseño e implementación de herencia, encapsulamiento de datos y modularidad de clases en C#.
- **Control de Flujo Avanzado:** Manejo de estructuras selectivas (`switch-case`) y bucles de control (`do-while`) para la construcción de menús interactivos resilientes.
- **Lógica Financiera y Validaciones:** Algoritmos para control de inventarios en tiempo real y cálculo automático de montos e impuestos (16% IVA).
- **Personalización de Consola:** Uso avanzado de la clase `System.Console` para formateo visual, limpieza de pantalla y mejora del UX en la consola de comandos de Windows.
