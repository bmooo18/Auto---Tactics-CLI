# Guia de programacion

## Referencias rapidas para el Markdown

| Objetivo          |                                    Markdown |
|:------------------|--------------------------------------------:|
| Encabezado 1      |                                # Encabezado |
| Negrita           |                               ## Encabezado |
| Negrita           |                                 **texto**   |
| Cursiva           |                                     *texto* |
| Negrita + cursiva |                                 ***texto*** |
| Tachado           |                                   ~~texto~~ |
| Enlace            | [ Encabezado]([texto](https://example.com)) |
| Imagen            |                          ![alt](imagen.png) |
| Código en línea   |                                    `código` |
| Cita              |                                      > cita |
| Viñeta            |                                  - elemento |
| Elemento numerado |                                 1. elemento |
| Tarea             |                                 - [ ] tarea |
| Línea horizontal  |                                         --- |

________________________________________________________________________________________

## Un flujo breve para analizar y resolver problemas


* Paso 1: Comprender el problema
* Identificar datos de entrada
* Identificar datos de salida
* Identificar restricciones


* Paso 2: Diseñar el algoritmo
* Escribir pasos en pseudocódigo
* Identificar operaciones necesarias


* Paso 3: Implementar
* Escribir código
* Usar nombres descriptivos
* Agregar comentarios


* Paso 4: Probar
* Probar con valores válidos
* Probar con valores límite
* Probar con valores inválidos


* Paso 5: Refinar
* Eliminar redundancias
* Mejorar legibilidad

________________________________________________________________________________________

## Una referencia breve para debugging, es decir, qué hacer si mi programa no funciona.


* Leer mensajes de error (indican problema y línea)
* Usar Console.WriteLine para mostrar valores intermedios
* Validar entrada del usuario
* Probar con casos simples

________________________________________________________________________________________

## 1. Entrada y salida por consola


Los dos son comandos


* `Console.Write` --> No agrega un salto de línea
* `Console.WriteLine` --> Agrega un salto de línea
* `Console.ReadLine()` --> Para solicitar información
  * Al solicitar entradas al usuario, estas se reciben como cadenas


```casharp
Console.WriteLine("¿Cual es tu nombre?");
string nombre = Console.ReadLine();
Console.Write("Hola ");
Console.Write( nombre + "!");
Console.WriteLine(" :)");
```


* `Console.Read()` --> Leer las teclas


* `Console.ReadKey()` --> leer un stream de texto


```casharp
// Solicitamos información al usuario
Console.WriteLine("Dame tu nombre: ");


// Leemos de forma infinita
// Ctrl + z o F6 también termina el programa
while (true)
{
   // Intercepta y muestra la tecla
   // var key = Console. ReadKey();
   // Intercepta y NO muestra la tecla
   var key = Console.ReadKey(true);


   // Si presiona Enter, salimos del bucle
   if(key.Key == ConsoleKey. Enter)
   {
       break;
   }


   // Mostramos la tecla presionada
   Console. Write(key.KeyChar);
}
```

* Comentarios
  * Existen diferentes tipos de comentarios, los principales son de "una línea" y "multilínea"
```casharp
// Comentario de una línea
/*
 * Comentario de
 * más de una
 * línea
*/
// TODO: Agregar todo permite colocar notas para el desarrollador
/// Tres barras permiten colocar comentarios de documentación de una línea
/**
 * Iniciando con dos asteriscos
 * es posible colocar comentarios de
 * documentación de más de una línea
**/

```

________________________________________________________________________________________

## 2. Secuencia de escape
Utilizando dentro de la cadena, es posible hacer que tanto Console. Write como Console. WriteLine muestran caracteres que de otra forma no son posibles.


* `\n (Salto de Línea)`: Agrega una salto de línea ("Enter") al texto.
* `\t (Tabulación)`: Permite alinear bloques de texto en columnas
* `\" (Comillas Dobles)`: Si se quiere insertar una " , es necesario agregar una \ antes para distinguirla del inicio y fin.
* `\\ (Barra Invertida)`: La \ es el carácter inicial de todas las secuencias, у se utiliza para "escapar", quedando como (I cuando se quiere mostrar


```casharp
Console.WriteLine("n\n\n");
//Crear un programa que muestre atributos en forma de tabla con un bader
Console.WriteLine("Estadísticas en forma de tabla");
Console.WriteLine("/ Greg \"El Mago\" /");
Console.WriteLine("\\----------------\\");
Console.WriteLine("/ HP \t100      /");
Console.WriteLine("\\ MP \t50       \\");
Console.WriteLine("/ Gold \t2,500    /");
Console.WriteLine("\\ Exp \t150      \\");
```

________________________________________________________________________________________

## 3. Mostrar valores en una cadenas


* CONCATENACIÓN - Utiliza el signo + para concatenar
```casharp
var sentencias = 6;
var cadena1    = "Hola";
var cadena2    = "mundo";


Console. WriteLine(cadena1 + " " + cadena2 + "!" );
Console.WriteLine("Este programa tiene " + sentencias + " sentencias." );
```


* INTERPOLACIÓN - Utiliza el signo $ para denotar y los valores encerrados en llaves { }
```casharp
var sentencias = 6;
var cadena1 = "Hola";
var cadena2 = "mundo";


Console.WriteLine($"{cadena1} {cadena2}");
Console. WriteLine($"Este programa tiene {sentencias} sentencias.");
```

________________________________________________________________________________________

## 4. Colores de fondo y texto en consola
La consola utiliza colores por defecto, por lo general:
* Fondo: Negro
* Texto: Blanco


Es posible configurar la consola utilizando los siguientes métodos:


* `Console. ForegroundColor`: Permite asignar un color al texto
* `Console. BackgroundColor`: Permite asignar un color al fondo
  Es importante regresar los colores a los valores por defecto al terminar:
* `Console. ResetColor()`: Regresa los colores a valores por defecto


```casharp
// Bandera de México en texto y color
Console.WriteLine("Bandera de México Texto");


Console. ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("MÉ");
Console. ForegroundColor = ConsoleColor.White;
Console. Write("XI");
Console. ForegroundColor = ConsoleColor.Red;
Console. Write("CO");


Console. ResetColor(); // Reiniciamos los colores
Console. WriteLine(); // Salto de línea


Console.WriteLine("Bandera de México Fondo");


// Texto en negro para el contraste
Console. ForegroundColor = ConsoleColor.Black;


Console. BackgroundColor = ConsoleColor. DarkGreen;
Console. Write("MÉ");
Console. BackgroundColor = ConsoleColor. White;
Console.Write("XI");
Console. BackgroundColor = ConsoleColor.Red;
Console. Write("CO");


Console. ResetColor(); // Reiniciamos los colores
```
________________________________________________________________________________________

## 5. Variables y tipos de Dato


Variable: Guarda información que puede cambiar
* variable nameMe

Constante: Guarda información que NO puede cambiar
* const variable NAME_ME


### Obtener y mostrar los valores min y max de un tipo de dato


```casharp
sbyte minValorSbyte = SByte.MinValue;
sbyte maxValorSbyte = SByte.MaxValue;


Console.WriteLine("SByte");
Console.WriteLine("Minimo: " + minValorSbyte);
Console.WriteLine("Maximo: " + maxValorSbyte);
```


### Operadores aritméticos, de comparación y lógicos.
* Símbolo de la suma (+)
* Símbolo de la resta (-)
* Símbolo de la multiplicación (*)
* Símbolo de la división (/)
* Módulo o residuo (%)


### Operadores específicos
* Símbolo de la suma (++) suma 1 al valor (num1++)
* Símbolo de la resta (--) resta 1 al valor (num1--)
* Símbolo de la multiplicación (+) devuelve el valor sin significado (+num1)
* Simbolo de la división (-) devuelve el valor negado del valor (-num1)
```casharp
 //Operaciones Unarias: + y
// Dependiendo de si es sufijo o prefijo, el resultado cambia
//El ejemplo siguiente aplica tanto para la suma (++) como para la resta (-)


var original = 10;            // Comenzamos con 10 entero
// ++ o -- como SUFIJO
// 1. Se guarda el valor de la operación 5 + 10 en 'num2' (Original = 10)
// 2. Se incrementa el valor de 'original' en 1, y se guarda en 'original'
// Resultado: num2 = 5 + 10 = 15 y original = 10 + 1 = 11
var num2     = 5 + original; // num2 = 15


//Original vale 11 ahora
// * -- como PREFIJO
// 1. Se incrementa el valor de 'original' en 1, y se guarda en 'original'
// 2. Se guarda el valor de la operación 5 + 12 en 'num3' (Oriğinal = 12)
// Resultado: original = 12 + 1 = 13 y num3 = 5 + 12 = 17
var num3 = 5 + original; // num3 = 17


// Original vale 12 ahora
// Sugerencia: No utilizar + o -- como parte de una operación aritmética
//             Realiza en incremento/decremento antes o después de form explícita
```


### Tipo de datos


### Números
Los números se pueden separar con guión bajo para facilitar la lectura


* sbyte sbyteVal = -127; // Valores positivos y negativos
* byte byteVal = +255; // Sólo valores positivos
* short shortVal = -32_767; // Valores positivos y negativos
* ushort ushortVal = +65_535; // Solo valores positivos
* int intVal -2_147_483_647; // Valores positivos y negativos
* uint uintVal = +4_294_967_295; // Solo valores positivos, u o U
* long longVal = -9_223_372_036_854_775_807; //Valores positivos y negativos, l o L
* ulong ulongVal = +18_446_744_073_709_551_615; // Solo valores positivos, u o U, l o L
* int randomDash = +1_23_456_7890_1234567_4_54; // Los guiones no tienen orden especial


Para decimales, es necesario utilizar un sufijo


* float = 3.141_159_265F; // Float debe llevar f o F
* double = 3.141_159_265; // Double puede no llevar sufijo
* double doubleVal2 = 3.141_159_265D; // o se puede utilizar D o d
* decimal decimalVal = 3.141_159_265M; // Decimal debe llevar M o m


Se puede utilizar notación científica/exponencial para facilitar la lectura


* float floatValExp = 8.148_484_599e12F; // e o E denota notación cientifica
* double doubleValExp = 8.148_484_599E-12; // e o E soporta valores negativos


Existen constantes para los valores mínimos y máximos de los tipos de dato numéricos


* sbyte sbyteMin = sbyte.MinValue; // -128
* double doubleMax = double.MaxValue; // 1.79769E+


Existen una variable para valores implícitos que no necesitan especificarse
* var name


### Obtener tipo de dato
* variable.GetType()
- byte --> System.Byte
- int --> System.Int32
- float --> System.Single


```casharp
sbyte SbyteValue = 1;


Console.WriteLine("SByteValue.GetType());
```




### Texto
* string: cadenas de texto (" ")


#### Métodos de las cadenas
* Length --> Longitud de la cadena (No lleva paréntesis)
* Contains() --> Verifica si una cadena contiene a otra
* EndsWith(cadena_a_comparar) --> Verifica si una cadena termina con otra
* StartsWith(cadena_a_comparar) --> Verifica si una cadena inicia con otra
* Replace(búsqueda, reemplazo) --> Reemplaza todas las ocurrencias de la cadena de búsqueda por la
  cadena de reemplazo
* Split(separador) --> Regresa un arreglo de cadenas, separadas por el separador
* SubString(inicio) --> Regresa una cadena de caracteres desde el índice indicado hasta el final
* SubString(inicio, fin) --> Regresa una cadena de caracteres desde el índice indicado hasta fin
* ToLower() --> Regresa la cadena con todas las letras en minúsculas
* ToUpper() --> Regresa la cadena con todas las letras en mayúsculas
* Trim() --> Elimina los espacios en blanco al inicio y fin de la cadena


```casharp
string cadena = " Esta es una cadena separada por espacios. ";


// Obtiene la longitud de la cadena
int longitud = cadena.Length;
Console.WriteLine("longitud: " + longitud); // 43 (Los espacios cuentan)


Console.WriteLine();


// Verifica si "Por" existe en la cadena
bool contienePorMayuscula = cadena.Contains("Por");
Console.WriteLine("contiene por mayuscula: " + contienePorMayuscula); // False, es sensible


Console.WriteLine();


// Verifica si "por" existe en la cadena
bool contienePorMinuscula = cadena.Contains("por");
Console.WriteLine("contiene por minúscula: " + contienePorMinuscula); // True, por existe ve


Console.WriteLine();


// Verifica si la cadena termina con un espacio en blanco
bool terminaConEspacio = cadena.EndsWith(" ");
Console.WriteLine("termina con un espacio: " + terminaConEspacio); // True (Termina con un e


Console.WriteLine();


// Verifica si la cadena empieza con la palabra "Esta"
bool comienzaConEsta = cadena.StartsWith("Esta");
Console.WriteLine("comience con la palabra Esta: " + comienzaConEsta); // "na separada por es


Console.WriteLine();


// Separa la cadena en un arreglo de cadenas por espacios
string[] palabras = cadena.Split(' '); // ["Esta", "es", "una", "cadena", "separada", "por"
for (int i = 0; i < palabras.Length; ++i)
{
Console.WriteLine("palabra " + i + ": " + palabras[i]);
}


Console.WriteLine();


// Obtiene la cadena a partir del índice 10
string subcadena = cadena.Substring(10);
Console.WriteLine("subcadena: " + subcadena); // E (El primer carácter es un espacio)


Console.WriteLine();


// Obtiene la cadena a partir del índice 1 hasta el 2
string primerCaracter = cadena.Substring(1, 2);
Console.WriteLine("Primer carácter: " + primerCaracter); // E (El primer carácter es un espa


Console.WriteLine();


// Obtiene la cadena a partir del índice 42 (longitud - 1)
string ultimoCaracter = cadena.Substring(cadena.Length - 2, 1);
Console.WriteLine("Último carácter: " + ultimoCaracter); // . (El último carácter es un espa


Console.WriteLine();


// Reemplaza los espacios por guiones
string espaciosPorGuiones = cadena.Replace(" ", "-");
Console.WriteLine("espacios por guiones: " + espaciosPorGuiones); // "-Esta-es-una-cadena-se


Console.WriteLine();


// Convierte la cadena a minúsculas
string minusculas = cadena.ToLower();
Console.WriteLine("minusculas: " + minusculas); // " esta es una cadena separada por espacio


Console.WriteLine();


// Convierte la cadena a mayúsculas
string mayusculas = cadena.ToUpper();
Console.WriteLine("mayusculas: " + mayusculas); // " ESTA ES UNA CADENA SEPARADA POR ESPACIO


Console.WriteLine();


// Elimina los espacios al inicio y al final
string eliminarEspacioInicoFin = cadena.Trim();
Console.WriteLine("eliminar espacios al inicio y al final: " + eliminarEspacioInicoFin);
```


* char: cadenas de caracteres  (' ')
* bool: true o false


### Operadores para booleanos relacionales
* Igual (==) Determina si dos valores son iguales
* Diferente (!=) Determina si dos valores son diferentes
* Mayor que (>) Determina si un valor es mayor que otro
* Menor que (<) determina si un valor es menor que otro
* Mayor o igual que (>=) Determina si un valor es mayoro igual que otro
* Menor o igual que (<=) Determina si un valor es menor o igual que otro


### Operadores para booleanos lógicos
* Negacion, NOT (!) Convierte un booleano a su negación (!true) = false
* Y, AND (&&) Determina si dos valores son verdaderos (true && true) = true
* O, OR (||) Determina si uno de dos valores es verdadero (true || false) = true

________________________________________________________________________________________

## 6. Conversiones entre tipos de dato, incluyendo parsing
* Parse --> realizar una conversión de cadena a numeros
```casharpe
// De string a entero
string intStr = "123";
int numVal = int.Parse(intStr);


// Genera un error, el valor no se puede convertir
// HOLA → No tiene sentido convertirla a un número
string str = "Hola";
int    strval = int. Parse(str);


// Podemos convertir la entrada del usuario
Console.Write("Dame un número: ");
string input = Console.ReadLine();
float  floatVal = float.Parse(input);
```
* TryParse --> Para convertir cadenas a números


```casharpe
// 1. De string a entero de forma segura
string intStr = "123";


// Usamos "out int runval" para capturar el resultado
if (int. TryParse(intStr, out int numVal)) {
   Console.WriteLine($"Conversión exitosa: (numVal)");
}
else {
   Console.WriteLine("No se pudo convertir a entero");
}


// 2. Manejo seguro de un valor inválido (como "No)
// Esto ya NO genera una excepción que rompa el pri la")
String str = "Hola";
if (int. TryParse(str, out int strval))
   {
       Console.WriteLine($"Conversión exitosas: (strVal)");
   }
   else
   {
       // "Hola" no es un número válido
       Console.WriteLine($"Error '(str)' no es válido");
   }
```
Ejemplo
```
//E2 - Genera un programa que pida un numeros entero hasta encontrar el correcto

string num;
bool   si;
int    numINT;
int    numCorrecto = 5;

do
{
    Console.WriteLine("Dame un numero entero");
    num = Console.ReadLine();
    si  = int.TryParse(num, out numINT);
    if (si == true)
    {
        if (numINT == numCorrecto)
        {
            Console.WriteLine("Numero correcto");
        }
        else
        {
            Console.WriteLine("Numero incorrecto, dame otro numero entero");
        }
    }
    else
    {
        Console.WriteLine("Dato no valido ");
    }

} while (numCorrecto != numINT);
```
________________________________________________________________________________________

## 7. Condicionales: `if`, `else`, `else if` y `switch`


* If --> El if evalúa una condición booleana. Si es falso, el programa salta ese bloque
* Else --> se coloca después del if, se ejecuta cuando la condición if es falsa

Sintaxis
```casharpe
if (condicion1)
{
 // Bloque de código que se ejecuta si condicion1 es True
}
else if (condicion2)
{
 // Bloque de código que se ejecuta si condicion1 es false and condicion2 es True
}
else
{
 // Bloque de código que se ejecuta si condicion1 es false and condicion2 es False
}

```

```casharpe
// Si la calificacion es aprobatoria o no


Random rnd = new Random();
int calificacion = rnd.Next(0,10);
Console.WriteLine(calificacion);
if (calificacion > 5) {Console.WriteLine("es aprobatoria");}
else {Console.WriteLine("no es aprobatoria");}




Console.Write("\n\n");


Console.Write("Ingresa un número: ");
int numero = int.Parse(Console.ReadLine());


Console.WriteLine("El número que ingresaste es: " + numero);


if (calificacion > 5) {Console.WriteLine("es aprobatoria");}
else {Console.WriteLine("no es aprobatoria");}
```

Ejemplo 2
```casharpe
// Programa que pida 1 entero y imprima la vida de un jugador


Console.WriteLine("Dame su vida");
int vidaJugador  = int.Parse(Console.ReadLine());


// Programa pide el nombre y apodo del jugador
Console.WriteLine("Dame el nombre");
String nombre  = Console.ReadLine();


Console.WriteLine("Dame el apodo");
String apodo  = Console.ReadLine();


//Pedir MP
int mana;
Console.WriteLine("Dame su MP");
var manaStr = Console.ReadLine();
//validar que sea entero
bool manaValido = int.TryParse(manaStr, out mana);
//mostrar tabla, sino mostrar error
if (manaValido == true)
{
   Console.Write("Nombre: " + nombre);
   Console.WriteLine(" \" " + apodo + " \" ");
   Console.WriteLine("HP: " + vidaJugador);
   Console.WriteLine("MP: " + mana);
}


else {Console.WriteLine("error");}
```
* else if --> Sirve para comprobar una nueva condición en secuencia si la primera condición del if fue falsa


```casharp
int calificacion = 8;
if (calificacion == 10) {
Console.WriteLine("Excelente.");
} else if (calificacion >= 7) {
Console.WriteLine("Aprobado.");
} else {
Console.WriteLine("Reprobado.");
}
```


* switch --> Permite seleccionar una acción entre múltiples alternativas concretas de un mismo valor
- case --> un posible valor
- break --> Termina ese caso
- default --> Ningún caso coincide

Sintaxis
```casharp
switch(expression)
{
 case x:
 // Bloque de código
 break;
 case y:
 // Bloque de código
 break;
 default:
 // Bloque de código
 break;
}

```

Ejemplo
```casharp
int opcion = 1;
switch (opcion)
{
   case 1:
       Console.WriteLine("Nueva partida");
       break;
   case 2:
       Console.WriteLine("Cargar partida");
       break;
   default:
       Console.WriteLine("Opción inválida");
       break;
}
```
- es posible combinar casos


Sintaxis
```casharp
switch (opcion) {
case OPCION1:
   case OPCION1:
   // Se ejecuta para opción 1
       break;
   case OPCION2:
   case OPCION3:
   // Se ejecuta para opción 2 o para opción 3 
       break;
   default:
   // Se ejecuta para cualquier otra opción 
       break;
      
```
Ejemplo
```casharp     
      
char calificacion = 'B';
switch (calificacion)
{
   case 'A':
       Console.WriteLine(" ¡Excelente!");
       break;
   case 'B':
   case 'C':
       Console.WriteLine("Aprobado con buen nivel.' break");
   case 'D':
   case 'F':
       Console.WriteLine("Reprobado o en riesgo.");
       break;
   default:
       Console.WriteLine("Calificación no válida.");
       break;
}
```
________________________________________________________________________________________

## 8. Ciclos


* while --> repite un bloque de código mientras la condición sea verdadera
* número de iteraciones 0 - N veces
* Revisa la condición: Antes de cada iteracion


Sintaxis
```casharp
while (condicion) {
   // codigo a ejecutarse
   // mientras se cumple
   // la condición
}
```
Ejemplo
```casharp     
// E1 - Genera un log de combate
int    daño   = 5;
Random rnd    = new Random();
int    numero = rnd.Next(1,50);
int    vida   = numero;
int    vidaDSP;


while (vida >= 0)
{
   Console.WriteLine("Vida del enemigo: " + vida);
   vida = vida - daño;
   Console.WriteLine("Vida del enemigo después del ataque: " + vida);
   Console.WriteLine("\n");
}
```


* DO-While --> Repite un bloque de código mientras la condición sea verdadera
    * número de iteraciones 1 - N veces
    * Revisa la condición: Después de cada iteración


Sintaxis
```casharp
do {
   // código a ejecutarse
   // al menos una vez
   // y mientras se
   // cumpla la condición
} while (condicion);
```
Ejemplo
```casharp     
//E2 - Genera un programa que pida un numero entero hasta encontrar el correcto


string num;
bool   si;
int    numINT;
int    numCorrecto = 5;


do
{
   Console.WriteLine("Dame un numero entero");
   num = Console.ReadLine();
   si = int.TryParse(num, out numINT);
   if (si == true)
   {
       if (numINT == numCorrecto)
       {
           Console.WriteLine("Numero correcto");
       }
       else
       {
           Console.WriteLine("Numero incorrecto, dame otro número entero");
       }
   }
   else
   {
       Console.WriteLine("Dato no válido ");
   }


} while (numCorrecto != numINT);
```


* For --> repite un bloque de código mientras la condición sea verdadera
    * número de iteraciones 0 - N veces
    * Revisa la condición: Antes de cada iteración
    * La inicializacion, condicion y el cambio forman parte de la sintaxis


Sintaxis
```casharp
while (inicio; condicion; cambio;) {
   // código a ejecutarse
   // mientras se cumpla
   // la condición
}
```
Ejemplo
```casharp     
//E3 - Genera un programa que multiplique la tabla del 7 hasta el 100


var seven = 7;
for (int tabla = 0;
    tabla <= 100;
    tabla++)
{
   Console.WriteLine(seven + " * " + tabla + " = " + tabla * 7);


}
```

* Break y Continue --> Permiten salir o continuar un ciclo

Ejemplo
```casharp
for (int i = 0; i < 10; i++)
{
     if (i == 4)
     {
     continue; // Cuando llega aquí, el ciclo se reinicia, ignorando el código de la iteració
     }
         if (i == 8)
         {
         break; // Cuando llega aquí, el ciclo se rompe y termina
         }
     Console.WriteLine(i);
}
// Imprime 0, 1, 2, 3, 5, 6 y 7, separados por salto de línea
// Omite el 4 por ser un continue y para al llegar al 8 (break)

```

________________________________________________________________________________________

| Necesito...                      | Arreglo |    Lista | Diccionario
|:---------------------------------|--------:|---------:|---:
| Guardar varios elementos         |      Sí |       Sí |Sí
| Elementos del mismo tipo         |      Sí |       Sí |Sí(clave/valor)
| Acceso mediante índice           |      Sí |       Sí |No
| Cantidad fija                    |      Sí |       No |No
| Ordenado                         |      Sí |       Sí |No
| Agregar/eliminar elementos       |      No |       Sí |Sí
| Cantidad de elementos            |  Length |    Count |Count
| Capacidad total                  |  Length | Capacity |Capacity
| Performance al acceder/modificar |       X |        X |
| Performance al buscar            |         |          |X
| Performance de memoria           |       X |          |
| Cantidad conocida de elementos   |       X |          |
| Cantidad variable de elementos   |         |        X |X
| Eliminar elementos               |         |        X |X
| Acceso por índice                |       X |        X |
| Acceso por clave                 |         |          |X


## 9. Arreglos basico --> cantidad definida

Un arreglo (array) es una estructura que permite almacenar múltiples valores del mismo tipo bajo un
solo nombre. Cada valor se guarda en una posición identificada por un índice numérico.

* Un arreglo guarda muchos valores del mismo tipo.

Sintaxis Crear un arreglo
```
// Tipo de dato + corchetes + identificador
string[] enemies;
// Longitud
enemies = new string[4];
// Tipo de dato + corchetes + identificador
string[] levels;

// Inicialización por valores
levels = [
"Forest",
"Cave",
"Castle",
];
```

Existen 3 formas de declarar un arreglo
* Vacio con longitud
* Con valores (Completa)
* Con valores ( Extencion)

```
// Declarar y crear un arreglo vacío de 4 elementos
string[] enemies = new string[4];

// Declarar un arreglo con valores 10, 25, 50
int[] scores = new int[] {
10, 25, 50
};

// Crear e inicializar sus valores mediante
// "Collection expression" utilizando corchetes
string[] levels = [
"Forest",
"Cave",
"Castle",

];
```

Ejemplo visual
```
    1      2  3  4 <---- Poscicion: Ubicación “natural” de un elemento.
[elemento][ ][ ][ ] 4 <---- Longitud: Cantidad de elementos que PUEDE contener
    0      1  2  3 <---- Indice: Ubicación “real” de un elemento.
```

* Obtener longitud: Console.WriteLine(Arreglo.Length);
* Obtener elementos: Arreglo[indice]
* Modificar elementos: ARREGLO[INDICE] = valor;


* Para recorrer un arreglo:
```
// Cuando necesitas conocer el índice o controlar el recorrido

for (int i = 0; i < enemies.Length; i++)
{
Console.WriteLine($"{i}: {enemies[i]}");
}
// for(iterador; condición; cambio)


//Cuando solo necesitas el elemento

foreach (string enemy in enemies)
{
Console.WriteLine(enemy);
}
// foreach(VARIABLE in ARREGLO)

```

Ejemplo
```
// Antes de ejecutar, responde:
// - ¿Cuántos valores contiene inventory?
// - ¿Qué representa [0]?
// - ¿Qué mostrará inventory[2]?
// - ¿Qué cambia en la línea 11?
// - ¿Cuántas veces se ejecutará el for?
// - ¿Qué contiene inventory.Length?


// Después de ejecutar, realiza estos cambios:
// - Reemplaza la declaración de valores por la de longitud
// - Asigna los valores
// - Agrega un nuevo elemento  "Espada" al arreglo
// - Asigna "Linterna" a inventory[inventory.Length - 1]
// - Imprime inventory.Length
// - Imprime los 4 valores
// - Asigna "Hacha" a inventory[5]
// - Asigna "Casco" a inventory[-1]


string[] inventory =
[
"Espada",
"Poción",
"Llave",
"Espada"
];

// Cuando necesitas conocer el índice o controlar el recorrido
for (var i = 0; i < inventory.Length; ++i)
{
Console.WriteLine(inventory[i]);
}

// Cuando solo necesitas el elemento
foreach (string enemy in enemies)
{
Console.WriteLine(enemy);
}
// foreach(VARIABLE in ARREGLO)


Console.WriteLine(inventory[0]);
Console.WriteLine(inventory[2]);

inventory[1] = "Escudo";

inventory[inventory.Length - 1]   = "Linterna";
// atajo inventory[^1] = "Linterna";


Console.WriteLine(inventory.Length);

for (var i = 0; i < inventory.Length; ++i)
{
Console.WriteLine(inventory[i]);
}

// error outside the bounds of the array
// inventory[5] = "Hacha";
// inventory[-1] = "Casco";
```

## 9.1. Arreglos avanzados
[ Arreglos Guia]([texto](https://drive.google.com/file/d/1tdg-LGUZC-kQIld2LdI13LaX1VVOIgLS/view))

* Usa variables -->  cuando solo necesitas un valor individual.
* Usa arreglos 1D --> cuando necesitas varios valores del mismo tipo.
* Usa 2D cuando --> tus datos tienen forma de tabla o mapa.
* Ejemplo visual
```
    C O L U M N A S
  F | [0] | [1] | [2]
  I ----|-----|-----|----
  L [0] | 5 | 8 | 3
  A [1] | 9 | 2 | 7
  S [2] | 4 | 6 | 1
  
  int[,] map = {
{5, 8, 3},
{9, 2, 7},
{4, 6, 1}
};
var letters = new char[5,3]; // 5 Filas x 3 Columnas
```
* Usa 3D cuando --> representas espacio o estructuras volumétricas.
* Ejemplo visual
```
   Nivel [0]
C O L U M N A S
F | [0] | [1]
I ----|-----|---
L [0] | 5 | 8
A [1] | 9 | 2
Nivel [1]
C O L U M N A S
F | [0] | [1]
I ----|-----|---
L [0] | 5 | 8
A [1] | 9 | 2

int[,,] cube = {
{
{1, 2},
{3, 4}
},
{
{5, 6},
{7, 8}
}
};
var letters = new char[5,3,7]; // 5 Filas x 3 Columnas x + Profundidad
```
* Arreglos Jagged (Irregulares) --> es una estantería irregular: cada fila tiene un número diferente de cajas

```
int[][] enemigosPorNivel = {
new int[] {1, 2, 3},
new int[] {4, 5},
new int[] {6}
};

// Representacion final
[0] ▢ ▢ ▢
[1] ▢ ▢
[2] ▢
```
### Declaración e Inicialización
En C#, los arreglos se declaran indicando el tipo de dato y el tamaño o los valores iniciales.
📌 Importante: El tamaño del arreglo no puede cambiar después de crearse.

* Declaración sin valores
En este caso, se debe definir la longitud desde el principio.
  * Tipo explícito:
```
// Una dimensión
int[] array1D = new int[3]; // 3 filas
// Dos dimensiones
int[,] array2D = new int[3,5]; // 3 filas, 5 columnas
// Tres dimensiones
int[,,] array3D = new int[3,5,9]; // 3 filas, 5 columnas, 9 profundudad
// Irregular / Jagged
int[][] jagged = new int[3][]; // 3 Filas
jagged[0] = new int[5]; // Fila #1, tiene 5 columnas
jagged[1] = new int[2]; // Fila #2, tiene 2 columnas
jagged[2] = new int[8]; // Fila #3, tiene 8 columnas
```
  * Tipo implícito:
```
// Una dimensión
var array1D = new int[3]; // 3 filas
// Dos dimensiones
var array2D = new int[3,5]; // 3 filas, 5 columnas
// Tres dimensiones
var array3D = new int[3,5,9]; // 3 filas, 5 columnas, 9 profundudad
// Irregular / Jagged
var jagged = new int[3][]; // 3 Filas
jagged[0] = new int[5]; // Fila #1, tiene 5 columnas
jagged[1] = new int[2]; // Fila #2, tiene 2 columnas
jagged[2] = new int[8]; // Fila #3, tiene 8 columnas
```
* Declaración con valores iniciales
La longitud del arreglo está determinada por la cantidad de elementos que se definen
    * Tipo explícito:
```
// Una dimensión
int[] array1D = new int[] { 12, 34, 56 }; // 3 elementos
// Dos dimensiones
int[,] array2D = new int[,] {
{ 11, 22, 33, 44, 55 }, // Fila 1, 5 elementos
{ 66, 77, 88, 99, 10 }, // Fila 2, 5 elementos
{ 21, 32, 43, 54, 65 }, // Fila 3, 5 elementos
};
// Tres dimensiones
int[,,] array3D = new int[,,] {
{ // Fila 1
{ 10, 11, 12, 13, 14, 15, 16, 17, 18 }, // Columna 1, 9 Profundidad
{ 19, 20, 21, 22, 23, 24, 25, 26, 27 }, // Columna 2, 9 Profundidad
{ 28, 29, 30, 31, 32, 33, 34, 35, 36 }, // Columna 3, 9 Profundidad
{ 37, 38, 39, 40, 41, 42, 43, 44, 45 }, // Columna 4, 9 Profundidad
{ 46, 47, 48, 49, 50, 51, 52, 53, 54 }, // Columna 5, 9 Profundidad
},
{ // Fila 2
{ 55, 56, 57, 58, 59, 60, 61, 62, 63 }, // Columna 1, 9 Profundidad
{ 64, 65, 66, 67, 68, 69, 70, 71, 72 }, // Columna 2, 9 Profundidad
{ 73, 74, 75, 76, 77, 78, 79, 80, 81 }, // Columna 3, 9 Profundidad
{ 82, 83, 84, 85, 86, 87, 88, 89, 90 }, // Columna 4, 9 Profundidad
{ 91, 92, 93, 94, 95, 96, 97, 98, 99 }, // Columna 5, 9 Profundidad
},
{ // Fila 3
{ 99, 98, 97, 96, 95, 94, 93, 92, 91 }, // Columna 1, 9 Profundidad
{ 90, 89, 88, 87, 86, 85, 84, 83, 82 }, // Columna 2, 9 Profundidad
{ 81, 80, 79, 78, 77, 76, 75, 74, 73 }, // Columna 3, 9 Profundidad
{ 72, 71, 70, 69, 68, 67, 66, 65, 64 }, // Columna 4, 9 Profundidad
{ 63, 62, 61, 60, 59, 58, 57, 56, 55 }, // Columna 5, 9 Profundidad
}
};
// Irregular / Jagged
int[][] jagged = new int[3][]
{
new int[] { 11, 22, 33, 44, 55 }, // Fila #1, 5 columnas
new int[] { 66, 77 }, // Fila #2, 2 columnas
new int[] { 88, 99, 10, 21, 32, 43, 54, 65 } // Fila #3, 8 columnas
};
```
    * Tipo implícito:
```
// Una dimensión
var array1D = new int[] { 12, 34, 56 }; // 3 elementos
// Dos dimensiones
var array2D = new int[,] {
{ 11, 22, 33, 44, 55 }, // Fila 1, 5 elementos
{ 66, 77, 88, 99, 10 }, // Fila 2, 5 elementos
{ 21, 32, 43, 54, 65 }, // Fila 3, 5 elementos
};
// Tres dimensiones
var array3D = new int[,,] {
{ // Fila 1
{ 10, 11, 12, 13, 14, 15, 16, 17, 18 }, // Columna 1, 9 Profundidad
{ 19, 20, 21, 22, 23, 24, 25, 26, 27 }, // Columna 2, 9 Profundidad
{ 28, 29, 30, 31, 32, 33, 34, 35, 36 }, // Columna 3, 9 Profundidad
{ 37, 38, 39, 40, 41, 42, 43, 44, 45 }, // Columna 4, 9 Profundidad
{ 46, 47, 48, 49, 50, 51, 52, 53, 54 }, // Columna 5, 9 Profundidad
},
{ // Fila 2
{ 55, 56, 57, 58, 59, 60, 61, 62, 63 }, // Columna 1, 9 Profundidad
{ 64, 65, 66, 67, 68, 69, 70, 71, 72 }, // Columna 2, 9 Profundidad
{ 73, 74, 75, 76, 77, 78, 79, 80, 81 }, // Columna 3, 9 Profundidad
{ 82, 83, 84, 85, 86, 87, 88, 89, 90 }, // Columna 4, 9 Profundidad
{ 91, 92, 93, 94, 95, 96, 97, 98, 99 }, // Columna 5, 9 Profundidad
},
{ // Fila 3
{ 99, 98, 97, 96, 95, 94, 93, 92, 91 }, // Columna 1, 9 Profundidad
{ 90, 89, 88, 87, 86, 85, 84, 83, 82 }, // Columna 2, 9 Profundidad
{ 81, 80, 79, 78, 77, 76, 75, 74, 73 }, // Columna 3, 9 Profundidad
{ 72, 71, 70, 69, 68, 67, 66, 65, 64 }, // Columna 4, 9 Profundidad
{ 63, 62, 61, 60, 59, 58, 57, 56, 55 }, // Columna 5, 9 Profundidad
}
};
// Irregular / Jagged
var jagged = new int[3][]
{
new int[] { 11, 22, 33, 44, 55 }, // Fila #1, 5 columnas
new int[] { 66, 77 }, // Fila #2, 2 columnas
new int[] { 88, 99, 10, 21, 32, 43, 54, 65 } // Fila #3, 8 columnas
};
```
* Propiedad .Length --> devuelve la cantidad total de elementos de un arreglo.
```  
int[] scores = {10, 20, 30, 40};
Console.WriteLine(scores.Length); // 4
```
* Método .GetLength(<dimensión>) --> devuelve la longitud de la dimensión (comenzando en 0 para las filas).
  * Usa .GetLength para arreglos "cuadrados". Utiliza Length para arreglos "irregulares/jagged".
```
int[,] matrix = new int[3,5];
Console.WriteLine(matrix.GetLength(0)); // 3 filas
Console.WriteLine(matrix.GetLength(1)); // 5 columnas
```
* Acceso y Modificación de Elementos
```
int[] vidas = {100, 80, 50, 50, 80, 44, 123, 99};
Console.WriteLine(vidas[0]); // Muestra 100
vidas[2] = 75; // Cambia la tercera vida a 75

// Para evitar errores, usa la propiedad .Length :
int[] vidas = {100, 80, 50, 50, 80, 44, 123, 99};
Console.WriteLine(vidas[vidas.Length - 1]); // 99

// Error común: Si intentas acceder a una posición fuera del rango, obtendrás un IndexOutOfRangeException .
int[] vidas = {100, 80, 50, 50, 80, 44, 123, 99};
Console.WriteLine(vidas[99]); // Error, no hay posición 99
```
* Operador "Sombrero": ^ --> Existe un operador especial que permite acceder al los elemento en reversa, iniciando en el último.
```
string[] words = new string[]{

// Indice desde el inicio // Índice desde el final

"primero",  // 0                ^10
"segundo",  // 1                ^9
"tercero",  // 2                ^8
"cuarto",   // 3                ^7
"quinto",   // 4                ^6
"sexto",    // 5                ^5
"séptimo",  // 6                ^4
"octavo",   // 7                ^3
"noveno",   // 8                ^2
"décimo"    // 9                ^1
};          // 10 (o
```

* Recorrido de arreglos: ^ --> Existe un operador especial que permite acceder al los elemento en reversa, iniciando en el último.
    * Ciclo for --> Cuando se necesita el índice, modificar elementos o recorrer por dimensiones.
```
// 1 Dimensión
for (int i = 0; i < values.Length; i++) {
Console.WriteLine($"Elemento {i}: {values[i]}");
}
// 3 Dimensiones (Cuadrado)
var rows = values.GetLength(0);
var cols = values.GetLength(1);
var depth = values.GetLength(2);
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < cols; j++)
{
for (int k = 0; k < depth; k++)
{
Console.WriteLine($"Elemento {i},{j},{k}: {values[i,j,k]}");
}
}
}
// 2 Dimensiones (Jagged)
for (int i = 0; i < values.Length; i++)
{
for (int j = 0; j < values[i].Length; j++)
{
Console.WriteLine($"Elemento {i},{j}: {values[i][j]}");
}
}
```
* Ciclo foreach --> Cuando solo se leen los valores.
```
// 1 Dimensión
foreach (int val in values)
{
    Console.WriteLine(val);
}
// 3 Dimensiones
foreach (int val in values)
{
    Console.WriteLine(val);
}
// 2 Dimensiones (Jagged)
foreach (var row in values)
{
    foreach (var val in row)
    {
    Console.Write(val + " ");
    }
    Console.WriteLine();
}
```

* Arreglos y Entrada del Usuario
```
int[] puntos = new int[3];
for (int i = 0; i < puntos.Length; i++)
{
Console.Write($"Puntuación del jugador {i + 1}: ");
var input = Console.ReadLine();
int.TryParse(input, out puntos[i]);
}
```

* Operaciones Comunes con Arreglos
  * Suma y promedio
```
// Utilizando for
var scores = new float[]{10f, 8.7f, 9.5f};
var sum = 0f;
var average = 0f;
for (int i = 0; i < scores.Length; i++)
{
sum += scores[i];
}
average = sum / scores.Length;
Console.WriteLine($"Total: {sum}, Promedio: {average}");

// Utilizando foreach
var scores = new float[]{10f, 8.7f, 9.5f};
var sum = 0f;
var average = 0f;
foreach (var score in scores)
{
sum += score;
}
average = sum / scores.Length;
Console.WriteLine($"Total: {sum}, Promedio: {average}");
```

* Valor máximo y mínimo
```
// Máximo - utilizando for
var scores = new int[]{5, 7, -5, 0, 10, 6, 8};
// Comenzamos con un valor del arreglo, cualquiera sirve
var max = scores[1]; // Por lo general se inicia con el primer elemento
for (int i = 1; i < scores.Length; i++)
{
// Máximo
if (scores[i] > max)
{
max = scores[i];
}
}
Console.WriteLine($"Max: {max}"); // 10

// Minimo - utilizando foreach
var scores = new int[]{5, 7, -5, 0, 10, 6, 8};
// Comenzamos con un valor del arreglo, cualquiera sirve
var min = scores[^1]; // Por lo general se inicia con el primer elemento
foreach (var score in scores)
{
    if (score < min)
    {
        min = score;
    }
}
Console.WriteLine($"Min: {min}"); // 10
```

* Métodos de la Clase Array
* Array.IndexOf() --> Busca la posición de un valor. --> Array.IndexOf(arr, 50)
* Array.Sort() --> Ordena los elementos. --> Array.Sort(scores)
* Array.Reverse() --> Invierte el orden. --> Array.Reverse(arr)
* Array.Copy() --> Copia elementos entre arreglos. --> Array.Copy(src, dst, n)

________________________________________________________________________________________

## 10. Listas Basico
[ Listas Guia]([texto](https://drive.google.com/file/d/1eVRmnJ_BeLmfcOjMeBdSdBzYiEwrV3uE/view))
Una lista es una estructura de datos que almacena una cantidad variable de
elementos del mismo tipo.

Ejemplo visual
```
    1      2  3  4 <---- Poscicion: Ubicación “natural” de un elemento.
[elemento][ ][ ][ ] 1 <---- Conteo: Cantidad de elementos que ESTAN conteniendo
                    4 <---- Capacidad: Cantidad de elementos que ESTAN CREADOS
    0      1  2  3 <---- Indice: Ubicación “real” de un elemento.
```

* Existen 4 formas principales de crear una lista:
```
// Lista sin capacidad inicial definida
List<string> enemies = new List<string>();
List<int> scores = new();
List<int> ranks = [];

// Lista con capacidad inicial de 5
List<string> levels = new List<string>(5);
List<int> worlds = new(5);

// Lista con valores iniciales y capacidad de 3
List<char> letters = new List<char>() { 'A', 'B', 'C' };

// Lista con valores iniciales y capacidad de 4
List<bool> answers = [
true, false, false, true
];
```

* Obtener la capacidad: Console.WriteLine($"Capacity: {LISTA.Capacity}"); // 0
* Obtener el conteo: Console.WriteLine($"Count: {LISTA.Count}"); // 0
* Agregar nuewvos elementos: LISTA.Add(VALOR);
* Inserta un valor en una posición específica: .Insert(<índice>, <valor>)
* Eliminar elemntos: LISTA.Remove(VALOR); 
  - // Este método elimina la primera aparición del valor. 
  - // Regresa un bool:
    - true: Encontrado y eliminado
    - false: No encontrado
* Eliminar elemntos indice: LISTA.RemoveAt(idx);
* Limpiar la lista: LISTA.Clear();
  - // Regresa un bool:
      - true: Encontrado y eliminado
      - false: No encontrado
* Obtener elementos: LISTA[INDICE]
* Modificasr elementos: LISTA[INDICE] = valor;
* Devuelve true si el elemento está en la lista: LISTA.Contains(valor)
```
List<string> inventario = new List<string>() { "Espada", "Escudo" };
if (inventario.Contains("Espada")){
Console.WriteLine("Tienes una espada equipada.");
}
```
* Devuelve el índice del valor especificado o -1 si no existe: .IndexOf(valor)
```
List<string> enemigos = new List<string>() { "Orco", "Lobo", "Dragón" };
int posL = enemigos.IndexOf("Lobo"); // 1
int posH = enemigos.IndexOf("lobo"); // -1, no existe, debe ser [L]obo
```
* Ordenan y revierten el contenido: .Sort() y .Reverse()
```
List<int> scores = new List<int>() { 50, 10, 30, 20 };
scores.Sort(); // [10, 20, 30, 50]
scores.Reverse(); // [50, 30, 20, 10]
```
* Recorrer un lista:
```
// Cuando necesitas conocer el índice o controlar el recorrido
for (int i = 0; i < enemies.Count; i++)
{
Console.WriteLine($"{i}: {enemies[i]}");
}
// for(iterador; condición; cambio)

// Cuando solo necesitas el elemento
foreach (string enemy in enemies)
{
Console.WriteLine(enemy);
}
// foreach(VARIABLE in LIST)
```
Ejemplo
```
// Listas

// Antes de ejecutar, responde:
// - ¿Cuántos elementos tiene enemies después de los tres Add?
// - ¿Qué representa Count?
// - ¿Qué pasa al agregar "Bat"?
// - ¿Qué hace Remove("Goblin")?
// - ¿Qué valores se imprimen?
// - ¿Cuál es la diferencia principal contra el arreglo anterior?

List<string> enemies = new List<string>()
{
"Slime"
};

enemies.Add("Slime");
enemies.Add("Orc");
enemies.Add("Goblin");

Console.WriteLine($"Enemigos: {enemies.Count}");

enemies.Add("Bat");

Console.WriteLine($"Enemigos: {enemies.Count}");

enemies.Remove("Goblin");

foreach (string enemy in enemies)
{
Console.WriteLine(enemy);
}
```

* Conversión entre Listas y Arreglos
  * Lista → Arreglo
```
List<int> valores = new List<int>() { 10, 20, 30 };
int[] array = valores.ToArray();
```
  * Arreglo → Lista
```
int[] numeros = { 1, 2, 3, 4 };
List<int> lista = numeros.ToList();

// Para usar .ToList() , agrega:
using System.Linq
```

## 10. Listas avanzado
permite almacenar múltiples valores del mismo tipo, pero a
diferencia de los arreglos, puede crecer o reducir su tamaño dinámicamente.

* Namespace --> es un contenedor lógico, que agrupa funcionalidad (clases, interfaces, estructuras, etc.) con el fin de organizar el código y evitar conflictos.
  * Es como una carpeta dentro de una computadora, dentro de la cual guardas archivos
    (en este caso, clases, interfaces, etc.).
    Puedes tener dos archivos con el mismo nombre, siempre y cuando estén en carpetas diferentes.
```
using System.Collections.Generic

// Sin el using, escribir el nombre completo
System.Collections.Generic.List<int> valores = new System.Collections.Generic.List<int>
```

Ejemplo visual
```
| Índice | Contenido  |
|--------|------------|
| [0]    | Espada     |
| [1]    | Poción     |
| [2]    | Llave Roja |
| [3]    | Escudo     |

List<string> inventario = new List<string>() {
"Espada", "Poción", "Llave Roja", "Escudo"
}; // Tiene una longitud de 4 elementos
```

________________________________________________________________________________________

## 11. Diccionario
Un diccionario es una estructura de datos que almacena pares de: Clave → Valor

Ejemplo visual
```
    
[elemento][ ][ ][ ] 1 <---- Conteo: Cantidad de elementos que ESTAN conteniendo
   llave  
[   10   ][ ][ ][ ] 4 <---- Capacidad: Cantidad de elementos que ESTAN CREADOS
   valor
```

* Crear un diccionario: 
```
// Sin capacidad inicial definida
Dictionary<string, int> items = new Dictionary<string, int>();
Dictionary<string, int> items = new();
Dictionary<string, int> items = [];

// Con capacidad inicial definida
Dictionary<string, int> items = new Dictionary<string, int>(5);
Dictionary<string, int> items = new(5);

// Con valores iniciales (Completa)
Dictionary<string, int> items = new Dictionary<string, int>()
{
{ "Espada", 25 },
{ "Arco", 15 },
{ "Hacha", 35 },
{ "Cuchillo", 0 }
};

// Con valores iniciales (Expresión)
Dictionary<string, int> items = new()
{
{ "Espada", 25 },
{ "Arco", 15 },
{ "Hacha", 35 },
{ "Cuchillo", 0 }
};
```
* Crear elemntos: Diccionario.Add(CLAVE, VALOR);
* Crear elemntos cuando se desconoce si existe: Diccionario.TryAdd(CLAVE, VALOR);
  - Regresa un bool:
    - true: Agregado
    - false: No agregado
* Obtener elementos: DICC[clave]
* Validar clave: Diccionario.ContainsKey(CLAVE)
* Obtener elementos cuando se desconoce si existe: Diccionario.TryGetValue(CLAVE,out VALOR)
* Eliminar elementos: Diccionario.Remove(CLAVE)
* Vaciar diccionario: Diccionario.Clear()


* Recorrer un diccionario
  - Se obtiene un KeyValuePair<TKey, TValue>
    - kv.Key: Clave del elemento
    - kv.Value: Valor del elemento
```
  // Podemos utilizar var para simplificar
  foreach (KeyValuePair<string, int> kv in d) {
  Console.WriteLine($"Key: {kv.Key}");
  Console.WriteLine($"Val: {kv.Value}");
  }
  
  // Podemos utilizar var para simplificar
  foreach (var kv in d) {
  Console.WriteLine($"Key: {kv.Key}");
  Console.WriteLine($"Val: {kv.Value}");
  }
```

Ejemplo
```
Dictionary<string, int> items = new()
{
{ "Espada", 25 },
{ "Arco", 15 },
{ "Hacha", 35 },
};
Console.WriteLine(items["Espada"]);
Console.WriteLine(items["Hacha"]);
items["Arco"] = 20;
Console.WriteLine(items["Arco"]);
if(items.ContainsKey("Hoz")) {
Console.WriteLine("DMG Hoz: " + items["Hoz"]);
}
if(items.TryGetValue("Hacha", out int dmg))
{
Console.WriteLine($"DMG hacha: {dmg}");
}
Console.WriteLine(items.Count);
```




---------------------------------------
-----------------------------
---------------------------------------
-----------------------------



# Guia de Auto-Tactics

## Clase 
Una clase es un molde: describe qué datos tiene algo y qué puede hacer.
```
//Card.cs
// Molde de cualquier carta del juego.
public class Card
{
public string Title;
public int Cost;
}
```
1. Clic derecho sobre el proyecto, Add → Class, nombre Unit.
2. Borra la línea namespace que Rider agrega

## Objeto y New
Un objeto (o instancia) es algo concreto creado con new
```
//Program.cs
// Dos objetos del mismo molde.
Card fireball = new Card();
fireball.Title = "Bola de fuego";
fireball.Cost = 3;

Card shield = new Card();
shield.Title = "Escudo";
shield.Cost = 1;

Console.WriteLine(fireball.Cost);   // 3
Console.WriteLine(shield.Cost);     // 1
```

## Campos
Un campo es una variable que pertenece al objeto.

Cada objeto guarda su propia copia y la conserva mientras exista.

|           |          Dónde vive |                   Cuánto dura |
|:----------|--------------------:|------------------------------:|
| Campo     |   Dentro del objeto |     Mientras el objeto exista |
| Parámetro |   Dentro del método | Mientras el método se ejecuta |

```
//Potion.cs
public class Potion
{
    public string Name;
    public int HealAmount;
}
```
Analogía: la hoja de personaje de un juego de rol. Las casillas vienen impresas; cada jugador llena la suya.

## Constructor
Es el método especial que se ejecuta al crear el objeto con new.

* Se llama igual que la clase.
* No tiene tipo de retorno, ni siquiera void.
* Su trabajo: dar valores iniciales a los campos.

``` 
//Potion.cs
public class Potion
{
    public string Name;
    public int HealAmount;
 
    // Recibe los valores iniciales y los guarda en los campos.
    public Potion(string name, int healAmount)
    {
        // name (minúscula) es el parámetro; Name (mayúscula), el campo.
        Name = name;
        HealAmount = healAmount;
    }
}
```
``` 
//Program.cs
Potion smallPotion = new Potion("Poción chica", 20);
Console.WriteLine(smallPotion.HealAmount);   // 20
```

## Metodo
Un método es una acción que el objeto sabe hacer.

Al definirlo indicas
* Acceso: public.
* Lo que devuelve: void si no devuelve nada.
* Nombre y parámetros.

Analogía: el botón de una linterna. «Gastar aceite» solo afecta a la linterna que sostienes.

``` 
//Lantern.cs
public class Lantern
{
    public int Oil;
 
    public Lantern(int oil)
    {
        Oil = oil;
    }
 
    // La linterna gasta tanto aceite como minutos encendida.
    public void Burn(int minutes)
    {
        Oil -= minutes;
    }
}
```
``` 
//Program.cs
Lantern mainLantern = new Lantern(100);
Lantern spareLantern = new Lantern(100);
 
mainLantern.Burn(30);
 
Console.WriteLine(mainLantern.Oil);    // 70
Console.WriteLine(spareLantern.Oil);   // 100: no se tocó
```

## RESUMEN PT1
* Clase: el molde.
* Objeto: algo concreto creado con new.
* Campo: un dato que pertenece al objeto; cada objeto tiene su copia.
* Constructor: da valores iniciales a los campos.
* Método: una acción que el objeto sabe hacer.

## CUATRO IDEAS
### Encapsulamiento
¿Qué significa que un objeto «controle su propio estado»?

Desde fuera solo se puede hacer lo que la clase permite. La clase protege sus datos y ofrece métodos que respetan sus reglas.

### public y private
¿Quién puede ver un miembro public? ¿Y uno private?

public es visible desde cualquier parte del programa. private solo se ve dentro de la misma clase.

### Propiedad con set privado
¿Qué significa { get; private set; }? ¿Y { get; } a secas?

Con { get; private set; }, cualquiera lee y solo la clase escribe. Con { get; }, el valor solo se asigna en el constructor.

### Propiedad calculada
¿En qué se diferencia de un campo?

No guarda un valor: lo calcula cada vez que se consulta. Se escribe con =>, que se lee «se calcula como»

## Composicion
La relación «tiene un»: un objeto tiene otros objetos.
* Lo guarda como una referencia y trabaja con él.
* knight.Weapon.Power se lee: la potencia del arma del caballero.

Analogía: un héroe equipado. Tiene un arma; no es un arma.
```
// Weapon.cs y Hero.cs
public class Weapon
{
public string Name { get; }
public int Power { get; }

    public Weapon(string name, int power)
    {
        Name = name;
        Power = power;
    }
}

public class Hero
{
public string Name { get; }
public Weapon Weapon { get; }   // el héroe tiene un arma

    public Hero(string name, Weapon weapon)
    {
        Name = name;
        Weapon = weapon;
    }
}
```
```
//Program.cs
Weapon sword = new Weapon("Espada", 7);
Hero knight = new Hero("Caballero", sword);
 
Console.WriteLine(knight.Weapon.Power);   // 7
```
## Coleccion de objetos
Una ```List<Item>``` es una lista cuyos elementos son referencias a objetos.

Se usa igual que las listas que ya conoces: Add, Count, lista[0] y foreach.

Analogía: las casillas del inventario de un juego. Cada una señala un objeto; no lo copia.
```
//Item.cs
public class Item
{
    public string Name { get; }
 
    public Item(string name)
    {
        Name = name;
    }
}
```
```
//Program.cs
List<Item> inventory = new List<Item>();
inventory.Add(new Item("Llave"));
inventory.Add(new Item("Antorcha"));
 
foreach (Item item in inventory)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine(inventory[0].Name);   // Llave
```

## Encapsula una coleccion
La lista es private; hacia fuera, solo métodos que respetan la regla.

Es la misma idea de s02: antes protegías un int; ahora proteges una colección.

Analogía: la mochila de un juego de supervivencia. No caben más cosas de las que caben: «mochila llena».
```
//Backpack.cs
public class Backpack
{
private List<Item> items = new List<Item>();

    public int Slots { get; }
    public bool IsFull => items.Count >= Slots;
 
    public Backpack(int slots)
    {
        Slots = slots;
    }
 
    public bool TryAdd(Item item)
    {
        if (IsFull)
        {
            return false;
        }
        items.Add(item);
        return true;
    }
}
```

## Miembros estacticos y de instancia
De instancia: pertenece a cada objeto. Estático: pertenece a la clase.

|                     |                        De instancia |                       Estático |
|:--------------------|------------------------------------:|-------------------------------:|
| Pertenece a         |                         Cada objeto |                       La clase |
| Se usa con          | Una variable que apunta a un objeto |          El nombre de la clase |
| Tiene estado propio |       Sí: cada unidad tiene su vida |  No hay objetos que distinguir |
| Ejemplos            |                  Unit, Army, Player |      Console, Math, ConsoleKit |

Analogía: la hoja de personaje de cada jugador frente al tablero de puntuaciones que todos comparten.

```
//Program.cs
// Estático: se llama con el nombre de la clase, sin new.
int best = Math.Max(3, 7);
 
// De instancia: se llama sobre un objeto.
Item key = new Item("Llave");
Console.WriteLine(key.Name);
```

## Interfaz publica
Para usar código de otra persona basta con su interfaz pública.

* Qué métodos ofrece.
* Qué recibe cada uno.
* Qué devuelve.

Analogía: el control remoto de la consola. Sabes qué botón hace qué, no cómo funciona el circuito.
```
//Program.cs
// Sabes qué recibe y qué devuelve; no cómo lo calcula.
double root = Math.Sqrt(16);
Console.WriteLine(root);   // 4
```

## Interfaz publica
Las clases del juego calculan y deciden. ConsoleView muestra y pregunta.

Analogía: un restaurante. La cocina cocina y el mesero sirve.

Diseño débil a propósito: la lógica también imprime.
```
//Backpack.cs
public bool TryAdd(Item item)
{
    if (IsFull)
    {
        Console.WriteLine("Mochila llena");   // la lógica también imprime
        return false;
    }
    items.Add(item);
    return true;
}
```
Con la responsabilidad separada: la lógica decide y la vista muestra.
```
// Program.cs
if (!backpack.TryAdd(key))
{
    view.ShowMessage("Mochila llena");   // la vista muestra
}
```
## RESUMEN PT3
* Composición: un objeto «tiene un» objeto. 
* Colección de objetos: una lista de referencias. 
* Encapsular una colección: lista privada y métodos que respetan la regla. 
* Estático frente a instancia: de la clase o de cada objeto. 
* Interfaz pública: lo único que necesitas conocer de código ajeno. 
* Separación de responsabilidades: la lógica decide, la vista muestra.

## Colaboracion entre objetos
Un objeto coordina a otros sin hacer su trabajo.

Analogía: un director de orquesta. No toca ningún instrumento; indica quién entra y cuándo.
```
//Slime.cs y Tower.cs
public class Slime
{
public int Health { get; private set; }

    public Slime(int health)
    {
        Health = health;
    }
 
    public void TakeDamage(int amount)
    {
        Health = Math.Max(Health - amount, 0);
    }
}

public class Tower
{
public int Damage { get; }

    public Tower(int damage)
    {
        Damage = damage;
    }
 
    // La torre no toca la vida del Slime: le pide que reciba el daño.
    public void Shoot(Slime target)
    {
        target.TakeDamage(Damage);
    }
}
```
```
// Program.cs
Tower tower = new Tower(3);
Slime slime = new Slime(5);
 
tower.Shoot(slime);
Console.WriteLine(slime.Health);   // 2
```

## Clase de datos
No tiene comportamiento: solo agrupa información relacionada.

Analogía: una ficha del marcador de un arcade. Nombre y puntos en una sola tarjeta.
```
// ScoreEntry.cs
public class ScoreEntry
{
    public string PlayerName { get; }
    public int Points { get; }
 
    public ScoreEntry(string playerName, int points)
    {
        PlayerName = playerName;
        Points = points;
    }
}
```
```
// Program.cs
List<ScoreEntry> table = new List<ScoreEntry>();
table.Add(new ScoreEntry("Ana", 1200));
table.Add(new ScoreEntry("Luis", 950));
 
foreach (ScoreEntry entry in table)
{
    Console.WriteLine($"{entry.PlayerName}: {entry.Points}");
}
```
## Detalle interno privado
(int) convierte un double a entero y descarta los decimales; no redondea.

Analogía: la cocina de un restaurante. El cliente pide el platillo.
```
public class Potion
{
    public int HealAmount { get; }
    public bool IsGreater { get; }
 
    public Potion(int baseHeal, bool isGreater)
    {
        IsGreater = isGreater;
        HealAmount = ApplyGrade(baseHeal);
    }
 
    private int ApplyGrade(int baseValue)
    {
        // Una poción mayor cura ×2.5, truncado a entero.
        if (IsGreater)
        {
            return (int)(baseValue * 2.5);
        }
        return baseValue;
    }
}
```
```
Potion small = new Potion(5, false);
Potion greater = new Potion(5, true);
 
Console.WriteLine(small.HealAmount);     // 5
Console.WriteLine(greater.HealAmount);   // 12, no 13: 12.5 se trunca
```

## Cursor
Un cursor es un índice que recuerda dónde iba.

* Avanza con (cursor + 1) % tamaño. 
* Al llegar al final, el residuo vuelve a 0. 
* Empieza en −1 para que el primer avance caiga en 0. 
* Cada bando tiene su propio cursor.

Analogía: la ruta de patrulla de un guardia. Al llegar al último punto, regresa al primero.
```
//Program.cs
List<string> route = new List<string>();
route.Add("Puerta");
route.Add("Almacén");
route.Add("Torre");
 
int current = -1;   // todavía no ha visitado ninguno
for (int i = 0; i < 5; i++)
{
    current = (current + 1) % route.Count;
    Console.WriteLine(route[current]);
}
```

## Conservar las derrotas
¿Quitar de la lista a las unidades derrotadas? No: se conservan y se pregunta IsAlive.

1. Quitar elementos mientras se recorre detiene el programa o desplaza los índices.
2. Los cursores apuntarían a posiciones que ya cambiaron.
3. Al final habría que reconstruir la fila.

Analogía: los jugadores eliminados de un battle royale. Siguen en el registro con la marca «eliminado».
```
public class Coin
{
public bool IsCollected { get; private set; }

    public void Collect()
    {
        IsCollected = true;
    }
}

List<Coin> coins = new List<Coin>();
coins.Add(new Coin());
coins.Add(new Coin());
coins.Add(new Coin());

coins[1].Collect();

int pending = 0;
foreach (Coin coin in coins)
{
if (!coin.IsCollected)
{
pending++;
}
}
Console.WriteLine(pending);       // 2
Console.WriteLine(coins.Count);   // 3: la moneda recogida sigue en la lista
```

## Datos de un diseñador
Traducir los datos a objetos sin cambiarlos. Si un nivel parece difícil, se respeta.

Analogía: pasar una partitura a un teclado. Cambiar una nota no rompe el programa, pero cambia la canción.
```
//Program.cs
// Fila del Excel, Nivel 1: vida 3 | vida 3 | vida 5
List<Slime> level1 = new List<Slime>();
level1.Add(new Slime(3));
level1.Add(new Slime(3));
level1.Add(new Slime(5));
```

## RESUMEN PT4
* Colaboración: un objeto coordina, cada uno hace su parte. 
* Clase de datos: agrupa información, sin comportamiento. 
* Detalle interno privado: private y (int) descarta los decimales. 
* Cursor: índice que recuerda dónde iba, con % da la vuelta. 
* Conservar a las derrotadas: no se quitan; se pregunta IsAlive. 
* Datos de un diseñador: se traducen sin cambiarlos.

