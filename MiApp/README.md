# Calculadora de IMC

Aplicación de consola en C# que calcula el Índice de Masa Corporal (IMC) y determina la condición de peso.

## Requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

> No se requieren dependencias ni paquetes adicionales.

## Verificar instalación

```bash
dotnet --version
```

Si el comando muestra una versión `10.x.x`, entonces fue exitoso.

## Ejecutar el programa

```bash
dotnet run
```

## Salida esperada

```
Estado: Peso normal
```

El programa calcula el IMC con los valores por defecto (peso: 75 kg, altura: 1.75 m) y muestra la condición correspondiente:

| IMC         | Estado      |
|-------------|-------------|
| < 18.5      | Bajo peso   |
| 18.5 – 24.9 | Peso normal |
| ≥ 25        | Sobrepeso   |
