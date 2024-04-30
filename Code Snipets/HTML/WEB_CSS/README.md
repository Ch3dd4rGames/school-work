La pseudoclase :hover solo se activará cuando el cursor se posicione encima del elemento 

En CSS tenemos funciones. Siempre tienen la estructura: nombre_de_funcion()

Los paréntesis están pegados al nombre y dentro contendrán el valor que acepta la función

------------

Para degradados de CSS -> https://cssgradient.io/

Para patrones de SVG -> https://heropatterns.com/

------------ 19/03/2024 ------------

Cargar tipografías externas, tenemos 2 tipos diferentes de tipografías y 2 formas diferentes de cargar estas tipografías:

- Tipografías de Google Fonts (cargadas de forma remota) -> 1) Cargamos con <link> o con @import y las usamos desde el CSS con font-family.

- Descargando archivos de fuentes y cargándolos en nuestra web.

POSICIONAMIENTO CON CSS:

La propiedad principal que define como se va a comportar un elemento y como se va a posicionar en relación al resto de elementos es la propiedad display.

- display: inline; (no modifican su ancho ni su alto)
- display: block;
- display: inline-block;

Con los elementos de tipo display:block podemos modificar su posición dependiendo del ancho que tengan y el espacio sobrante que exista en el contenedor que los contiene. Mediante la propiedad margin podemos desplazar el elemento a través del espacio sobrante dentro de su contenedor con el valor auto.

UNIDADES DE MEDIDA EN CSS:

- Pixeles (px): Es una medida ABSOLUTA. No varía entre diferentes tamaños de pantalla, aunque la percepción del tamaño puede ser diferente.

- Medidas relativas al tamaño de la fuente (em, rem): Esta medida será RELATIVA al tamaño de la fuente que configuremos en nuestro CSS con la propiedad font-size. El tamaño por defecto de la fuente en el documento es de 16px.

- Porcentajes (%): El porcentaje es RELATIVO al tamaño del contenedor. El tamaño en porcentaje de un elemento hace referencia al tamaño del elemento que lo contiene y este tamaño puede ser a la vez otro porcentaje. Pueden existir elementos con tamaños en porcentajes anidados.

- Medidas relativas al tamaño de la pantalla (viewport, la ventana del navegador que ve el usuario): vw, vh -> medidas relativas al ancho del viewport y al alto del viewport.

FLEXBOX:

Flexbox es un modelo de layout de CSS. Se trata de una serie de propiedades para organizar y maquetar nuestro CSS y de esta forma conseguir la distribución de los elementos para satisfacer mi diseño.

Gracias a las propiedades de flexbox podemos ignorar el tipo de display de los elementos que queremos posicionar.

El primer paso para poder posicionar elementos con flexbox es identificar
del contenedor.

Propiedades de los hijos o items flex:
- order: (cualquier número) el valor por defecto es 0.

- 3 propiedades que resumimos en 1: flex-grow, flex-shrink, flex-basis -> flex (se recomienda usar la forma shorthand). Nos permite manejar el tamaño de los hijos o items flex.

-align-self: toma los mismos valores que align-items pero de forma individual por lo que podemos cambiar la alineación de un elemento hijo determinado.

PROPIEDAD POSITION:

La propiedad position me permite definir cómo se comporta un elemento en relación al resto de elementos del layout en cuanto a su posición.

Cuando un elemento tiene la propiedad position: absolute; este elemento ignorará al resto de elementos del layout y lo podré mover y posicionar libremente usando las propiedades top, right, bottom y left como si fuesen coordenadas x e y.

Cuando un elemento tiene la propiedad position: absolute;
tendrá prioridad en el eje z en relación al resto de elementos (por defecto, esto podríamos modificarlo).

Si queremos que un elemento con position: absolute se posicione en relación a un contenedor determinado tendré que usar la propiedad position: relative; en dicho contenedor.

-----------------------
MEDIA QUERIES (RESPONSIVE WEB DESIGN)
-----------------------

3 NORMAS a tener en cuenta cuando diseñemos y desarrollemos con el concepto o paradigma RWD

1) En todos los archivos de HTML que usemos en nuestra web tendremos localizada en el <head> la etiqueta <meta name="viewport" content="width=device-width, initial-scale=1.0>

2) No usaremos medidas absolutas (píxeles) ni para definir anchos de contenedores ni para medidas de margin o padding (cuando estas medidas sean relativamente grandes) porque lo más seguro es que se rompa el layout. Siempre intentaremos usar unidades relativas, si queremos que sean fijas podemos usar "em" y si queremos que sean totalmente relativas usaremos %.

3) La web se debe adaptar, funcionar y ver correctamente en todos los tamaños de pantalla (como mínimo podemos tomar la medida de 350px de ancho). Podemos emular pantallas de cualquier medida usando la herramienta "Device Toolbar" de DevTools en la opción responsive.

-----------------------
ANIMACIONES CON CSS3
-----------------------

Para poder usar animaciones de CSS3 vamos a seguir 2 pasos:

1) Planificar la animación (que hace y sobre que elemento actua) y definir la animación con la regla especial @keyframes y le daremos un nombre a la animación (este nombre lo decidimos nosotros)

2) Dentro del selector al que quiero que afecte la animación usaré las propiedades de animation-...
    - animation-name
    - animation-duration
    - animation-delay
    - animation-iteration-count
    - animation-direction
    - animation-timing-function
    - animation-fill-mode
    - animation (shorthand)