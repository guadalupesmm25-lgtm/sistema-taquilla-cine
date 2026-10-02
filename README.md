# Sistema de Venta de Boletos y Dulcería (C# & .NET)

## Descripción
Aplicación de consola desarrollada en C# (.NET) que simula el funcionamiento de un sistema de punto de venta (POS) para una cadena de cines. El proyecto aplica principios de Programación Orientada a Objetos (POO) como herencia y encapsulamiento para gestionar de manera modular la selección de salas, cartelera, alimentos y facturación.

## Objetivo
Desarrollar una interfaz de consola interactiva que permita autenticar usuarios, seleccionar la sucursal cinematográfica, elegir películas con verificación de inventario, personalizar productos en dulcería y generar comprobantes detallados con cálculo automático de impuestos.

## Estructura de clases
- **Usuario (Clase base):** Gestiona la autenticación inicial, selección de sucursal y control de navegación general.
- **Movie_Menu (Subclase):** Despliega la cartelera disponible, valida la capacidad de la sala y realiza el cálculo de costos de boletos incluyendo impuestos.
- **Food_Menu (Subclase):** Administra el catálogo de dulcería, la selección de opciones o sabores y emite el desglose correspondiente.

## Habilidades y conceptos aplicados
- **Programación Orientada a Objetos:** Implementación de herencia, encapsulamiento y estructuras modulares en C#.
- **Control de flujo e interactividad:** Uso de estructuras iterativas y condicionales para construir menús interactivos en consola.
- **Lógica de negocio y cálculo financiero:** Algoritmos para control de inventarios, validación de disponibilidad y aplicación de impuestos (16% IVA).
- **Diseño de consola (UX):** Formateo visual y gestión de pantalla utilizando métodos de la clase `System.Console` para mejorar la experiencia de uso.
