# TareaAplicativo
Tarea de Apoyo, solicitada por Sebastián


1.- Crear una aplicacion en consola que la pantalla inicial presente el siguiente menú

       1.- Añadir persona
       2.- Eliminar persona
       3.- Buscar persona
       4.- Listar persona
       5.- Salir

       Para ingresar a cada operacion basta con presionar el numero del menú 1 a 5

       La primera opcion debe permitir la creacion de una nueva persona con los siguientes atributos
           - Identificador o RUT  (string)
           - Nombre (string)
           - Apellidos (string)
           - Edad (int)
           - Fecha de Nacimiento (datetime)
           - Sexo (char)

       Cada atributo debe tener su tipo de dato respectivo.

       La persona creada debe ser guardada en una listas del mismo tipo, esta lista permitirá agregar más personas a ella y ejecutar las demás operaciones.

       La siguiente accion, "Eliminar persona", debe permitir sacar a la persona de la lista, a partir del RUT ingresado, si no lo encuentra, debe indicar que no existe en los registros.

       La tercera opcion, debe permitir la busqueda de una persona por el RUT ingresado, y debe mostrar en pantalla la siguiente informacion.
           -Nombre Completo
           -RUT
           -Fecha de Nacimiento
           -Sexo

       Además en la misma pantalla, se debe mostrar los siguiente mensajes.
           -Indicar si es mayor de edad o no, es mayor de edad si tiene 18 años o más
           -Indicar su edad a partir de la fecha de nacimiento

       La cuarta opcion, debe listar todos los usuarios almacenados hasta el momento, indicando la siguiente informacion para cada uno de ellos
           -Nombre Completo
           -RUT
           -Edad
           -Fecha de Nacimiento
           -Sexo


       Cada menú de la aplicación debe permitir volver al menú principal al terminar la operacion, ya sea de manera automatica o con alguna tecla en especial.

       Finalmente al presionar "5", se debe cerrar la aplicacion.
