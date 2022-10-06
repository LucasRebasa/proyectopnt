# proyectopnt
Link a la documentacion: https://docs.google.com/document/d/1Jvap3NN5GUnDBrNJ1QdeLWXfskNGZZ00ySj4ykDfq9I/edit <br>
Gestor de proyectos<br>
Aplicación tipo Trello que permite crear tareas a realizar, filtrarlas dependiendo su estado (no iniciada, en proceso, finalizada, etc). Se pueden subir archivos, imágenes y texto separados en distintas tarjetas. Los usuarios tienen sesiones y pueden invitar a otros a participar en su proyecto. Se almacenan los datos y estadísticas de cada usuario (los proyectos en los que participo y en los que participa, la cantidad, etc)

GitHub: https://github.com/LucasRebasa/proyectopnt

Funcionalidades:

Inicio de sesión  (Prioridad alta)

Creación de cuenta (Prioridad alta)

Creación de tarjetas editables (Prioridad alta)

Envío de invitaciones a otros usuarios (Prioridad media)

Múltiples pantallas/pestañas para un mismo proyecto (Prioridad baja)

Almacenamiento de datos (Prioridad alta)

Visibilidad del proyecto (público / privado) (Prioridad media)

Personalización de perfil (Prioridad baja)

Descripción funcionalidades<br>
1)Mediante un nombre de usuario y contraseña, se valida que estos datos coincidan con un usuario de la base de datos.<br>
2)Se crea un usuario con nombre y contraseña y se almacena en la base de datos.<br>
3)Se crean tarjetas que pueden contener información en formato texto, imagen o archivo y tienen un título. Está dividida en campos (de tipo texto, imagen o archivo).<br>
4)El usuario puede invitar a otros usuarios a colaborar en sus proyectos enviando invitaciones por nombre. <br>
5)Un mismo proyecto puede tener distintas pantallas. Se muestran de a una y sirven para separar al proyecto en distintas partes/etapas según el usuario prefiera.<br>
6)Se almacenan en la base de datos los usuarios y los proyectos con sus respectivas tarjetas.<br>
7)Un proyecto puede ser visible solo para el usuario o para las personas que el usuario asigne (privado), o para cualquier usuario (público).<br>
8)El usuario puede modificar su nombre y contraseña como desee.<br>

Validaciones e ingresos de datos<br>
1)Se ingresa un usuario y contraseña. Se valida que los datos ingresados sean correctos, coincidiendo el nombre y la contraseña con un usuario ya ingresado en la base de datos.<br>
2)Se ingresa un usuario y contraseña. Se valida que la contraseña sea mayor a 10 caracteres y que contenga números y letras. Además se valida que el nombre no este utilizado por otro usuario.<br>
3)Se ingresa un nombre y se especifica un color para la tarjeta. Se valida que los campos obligatorios de la tarjeta no sean vacíos (nombre…).<br>
4)Se ingresa un nombre de usuario. Se valida que el nombre de usuario exista, no esté vacío y que la persona que envía la solicitud tenga acceso al proyecto.<br>
5)Se añade otra pantalla/pestaña con un botón.<br>
6)Todos los datos ingresados deben estar en el formato correcto.<br>
7)Se especifica cual es la visibilidad del proyecto. Se valida que el usuario tenga acceso al proyecto ya sea para verlo o para modificarlo.<br>
8)Se ingresa un nombre y/o una contraseña. Se valida que el nombre no exista en la base de datos y que la contraseña sea segura.<br>
