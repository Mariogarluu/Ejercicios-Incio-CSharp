# Ejercicios de Inicio en C#

Este repositorio contiene una colección de 10 ejercicios fundamentales de programación en C# diseñados para aprender y practicar conceptos básicos del lenguaje. Los ejercicios cubren desde estructuras de datos básicas hasta programación orientada a objetos.

## 📋 Requisitos

- .NET Framework 4.7.2 o superior
- Visual Studio 2019 o superior (recomendado)
- Conocimientos básicos de C#

## 🚀 Instalación y Ejecución

1. Clona este repositorio:
   ```bash
   git clone https://github.com/Mariogarluu/Ejercicios-Incio-C-.git
   ```

2. Abre la solución en Visual Studio:
   - Abre el archivo `Tarea 3.sln` con Visual Studio

3. Compila y ejecuta el proyecto:
   - Presiona `F5` para ejecutar en modo debug
   - O presiona `Ctrl + F5` para ejecutar sin debug

4. El programa mostrará un menú interactivo donde podrás seleccionar qué ejercicio ejecutar.

## 📚 Ejercicios Incluidos

### Ejercicio 1: Suma y Media de un Array
**Conceptos:** Arrays, bucles, entrada/salida de datos

El programa solicita al usuario:
1. El tamaño del array a crear
2. Los valores para cada elemento del array
3. Calcula y muestra la suma total y la media de todos los valores

**Ejemplo de uso:**
```
Introduce el tamaño del array: 3
Introduce el valor del elemento 1: 10
Introduce el valor del elemento 2: 20
Introduce el valor del elemento 3: 30
La suma de los elementos es: 60
La media de los elementos es: 20
```

---

### Ejercicio 2: Contador de Espacios en Blanco
**Conceptos:** Cadenas de texto, funciones, iteración de caracteres

Implementa una función `ContarEspacios()` que:
- Recibe una cadena de texto como parámetro
- Cuenta el número de espacios en blanco
- Devuelve el total de espacios encontrados

**Ejemplo de uso:**
```
Introduce una cadena de texto: Hola mundo de C#
El número de espacios en blanco es: 3
```

---

### Ejercicio 3: Cálculo del Factorial (Recursivo)
**Conceptos:** Recursividad, funciones matemáticas

Implementa una función recursiva `CalcularFactorial()` que calcula el factorial de un número:
- Formula: n! = n × (n-1) × (n-2) × ... × 3 × 2 × 1
- Ejemplo: 6! = 6 × 5 × 4 × 3 × 2 × 1 = 720

**Ejemplo de uso:**
```
Introduce un número para calcular su factorial: 5
El factorial de 5 es: 120
```

---

### Ejercicio 4: Verificador de Números Primos
**Conceptos:** Algoritmos, funciones booleanas, matemáticas

Implementa una función `EsPrimo()` que determina si un número es primo:
- Un número primo solo es divisible por 1 y por sí mismo
- Utiliza optimización verificando divisores hasta la raíz cuadrada del número

**Ejemplo de uso:**
```
Introduce un número para comprobar si es primo: 17
El número 17 es primo.
```

---

### Ejercicio 5: Cálculo de Potencias (Iterativo y Recursivo)
**Conceptos:** Recursividad vs iteración, operaciones matemáticas

Implementa dos funciones para calcular potencias sin usar `Math.Pow()`:
- `CalcularPotenciaIterativa()`: Usa un bucle for
- `CalcularPotenciaRecursiva()`: Usa recursividad

**Ejemplo de uso:**
```
Introduce la base: 2
Introduce el exponente: 3
Resultado (Iterativo): 8
Resultado (Recursivo): 8
```

---

### Ejercicio 6: Sistema de Login
**Conceptos:** Validación de datos, control de acceso, bucles

Implementa un sistema de autenticación con:
- Usuario válido: `usuario2DAM`
- Contraseña válida: `pass2DAM`
- La función `ComprobarLogin()` verifica las credenciales

**Ejemplo de uso:**
```
Introduce el usuario: usuario2DAM
Introduce la contraseña: pass2DAM
Login correcto. Bienvenido.
```

---

### Ejercicio 7: Verificador de Múltiplos
**Conceptos:** Operaciones módulo, funciones booleanas

Implementa una función `EsMultiplo()` que:
- Recibe dos números enteros
- Determina si el primero es múltiplo del segundo
- Usa el operador módulo (%) para la verificación

**Ejemplo de uso:**
```
Introduce el primer número: 15
Introduce el segundo número: 5
El número 15 es múltiplo de 5
```

---

### Ejercicio 8: Suma de Dígitos
**Conceptos:** Manipulación de números, operaciones módulo

Implementa una función `CalcularSumaDigitos()` que:
- Extrae cada dígito de un número
- Suma todos los dígitos individuales
- Ejemplo: 23 → 2 + 3 = 5

**Ejemplo de uso:**
```
Introduce un número: 123
La suma de los dígitos de 123 es: 6
```

---

### Ejercicio 9: Encontrar Mínimo en un Array
**Conceptos:** Búsqueda en arrays, algoritmos de búsqueda

Implementa una función `EncontrarMinimo()` que:
- Recibe un array de enteros
- Encuentra el valor mínimo
- Devuelve la posición (índice) del número menor

**Ejemplo de uso:**
```
Array: {-15, 3, 8, 7, -7, 1, 4}
La posición del número menor es: 0
(El número -15 está en la posición 0)
```

---

### Ejercicio 10: Simulador de Banco (POO)
**Conceptos:** Programación Orientada a Objetos, clases, encapsulamiento

Implementa un sistema bancario completo con dos clases:

**Clase Cliente:**
- Campos: `nombre`, `cantidadTotal`
- Métodos:
  - `Ingresar(cantidad)`: Añade dinero a la cuenta
  - `Sacar(cantidad)`: Retira dinero de la cuenta
  - `GetCantidadTotal()`: Devuelve el saldo actual
  - `MostrarInformacion()`: Muestra información del cliente

**Clase Banco:**
- Gestiona tres clientes
- Métodos:
  - `Operar()`: Realiza operaciones iniciales
  - `ObtenerEstado()`: Muestra el estado del banco y de cada cliente

**Ejemplo de uso:**
```
Bienvenido al banco
Total ingresado en el banco: 4500
Cliente: Cliente 1, Cantidad Total: 1000
Cliente: Cliente 2, Cantidad Total: 2000
Cliente: Cliente 3, Cantidad Total: 1500
Pulse 1 para ingresar dinero, 2 para sacar dinero, 0 para salir:
```

## 🏗️ Estructura del Proyecto

```
Ejercicios-Incio-C-/
│
├── Tarea 3.sln              # Solución de Visual Studio
├── README.md                # Este archivo
│
└── Tarea 3/
    ├── Program.cs           # Archivo principal con todos los ejercicios
    ├── Tarea 3.csproj       # Archivo de proyecto
    ├── App.config           # Configuración de la aplicación
    └── Properties/
        └── AssemblyInfo.cs  # Información del ensamblado
```

## 🛠️ Tecnologías Utilizadas

- **Lenguaje:** C#
- **Framework:** .NET Framework 4.7.2
- **IDE:** Visual Studio
- **Paradigmas:** Programación procedural y Programación Orientada a Objetos

## 💡 Conceptos de Programación Cubiertos

- ✅ Variables y tipos de datos
- ✅ Estructuras de control (if, while, for, switch)
- ✅ Arrays y colecciones
- ✅ Funciones y métodos
- ✅ Recursividad
- ✅ Programación Orientada a Objetos (clases, objetos, encapsulamiento)
- ✅ Entrada y salida de datos por consola
- ✅ Validación de datos
- ✅ Algoritmos básicos (búsqueda, verificación, cálculos matemáticos)

## 📝 Notas

- Cada ejercicio está implementado como un método estático independiente
- El programa principal (`Main`) presenta un menú interactivo para seleccionar qué ejercicio ejecutar
- Todos los ejercicios incluyen validación básica de entrada
- El código incluye comentarios explicativos en español

## 👨‍💻 Autor

Mario García

## 📄 Licencia

Este proyecto es de código abierto y está disponible para fines educativos.
