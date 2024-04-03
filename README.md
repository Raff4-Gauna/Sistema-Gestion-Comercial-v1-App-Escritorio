# Escenario: Desarrollo de un Sistema de Gestión Comercial Modular
Contexto:

La empresa "Comercializadora ABC" está buscando desarrollar un sistema de gestión comercial modular que les permita mejorar la eficiencia 
de sus operaciones y optimizar la gestión de su negocio. 

El sistema estará dividido en diferentes módulos:
- Configuración.
- Socios.
- Inventario.
- Ventas.
- Compras.
- Reportes.

## Desarrollo del Sistema:
Para desarrollar el sistema de gestión comercial modular, se seguirán los siguientes pasos:

✔️ Análisis de Requerimientos: Se realizará un análisis detallado de los requerimientos para cada módulo y submódulo del sistema, identificando las funcionalidades específicas que deben ser implementadas.

✔️ Diseño Modular: Se diseñará el sistema de forma modular, dividiendo las funcionalidades en módulos independientes que actúan como contenedores para los diferentes menús y submenús.

✔️ Desarrollo de Módulos: Se procederá con el desarrollo de cada módulo del sistema, siguiendo las mejores prácticas de desarrollo de software y utilizando tecnologías modernas y escalables.

✔️ Implementación y Capacitación: Una vez que el sistema esté listo, se procederá a su implementación en el entorno de producción y se brindará capacitación al personal de "Comercializadora ABC" para garantizar su correcto uso y aprovechamiento.

-----------------------------------------------------------------------------------------------------------------------------------------------------------

Adicionalmente, como parte de la implementación del sistema de gestión comercial, se incorporó un robusto control de licencia. Este control se basa en la asignación de una fecha de inicio y fin de contrato para cada licencia de uso del software. 

Al llegar a la fecha de finalización del contrato, el sistema se bloqueará temporalmente, impidiendo el acceso a los usuarios hasta que se realice la renovación del contrato correspondiente. 

Esta medida garantiza la legalidad y el cumplimiento de los términos de uso del software, así como también brinda seguridad y control sobre su distribución y utilización.

-----------------------------------------------------------------------------------------------------------------------------------------------------------

### Para el Desarrollo del Sistema utilize las siguientes Tecnologías:

- Sql Server.
- C# (.Net) .

### Versiones utilizadas
- Sql Server --> 2008 / 2014.
- C# (.Net) --> Visual Studio 2019 con el Framework 4.7 para el proyecto.

### IMPORTANTE
La arquitectura cliente-servidor para el proyecto proporciona una estructura organizada donde el cliente, que es la interfaz de usuario del sistema de gestión comercial, solicita servicios o recursos al servidor, que es 
la parte central del sistema. El servidor maneja estas solicitudes y procesa la lógica de negocio, accediendo a la base de datos y coordinando la comunicación con el cliente.

### Principios SOLID Aplicados:

S (Single Responsibility Principle - Principio de Responsabilidad Única): Cada módulo del sistema se diseñó para tener una única responsabilidad o propósito. Por ejemplo, el módulo de ventas se encarga exclusivamente de gestionar las transacciones de venta, mientras que el módulo de inventario se encarga de gestionar el stock y los productos.

O (Open/Closed Principle - Principio de Abierto/Cerrado): Los módulos del sistema fueron diseñados para ser abiertos para la extensión pero cerrados para la modificación. Esto significa que pueden añadirse nuevas funcionalidades o características sin necesidad de modificar el código existente, lo que promueve la reutilización y la modularidad del sistema.

L (Liskov Substitution Principle - Principio de Sustitución de Liskov): Se garantizó que los subtipos de los objetos del sistema pudieran ser sustituidos por sus tipos base sin afectar el comportamiento esperado del sistema. Por ejemplo, los diferentes tipos de usuarios (administradores, empleados, etc.) pueden ser tratados de manera uniforme en el sistema.

I (Interface Segregation Principle - Principio de Segregación de Interfaces): Se utilizaron interfaces para definir contratos específicos entre los diferentes componentes del sistema, lo que permitió una mayor cohesión y un menor acoplamiento entre ellos. Por ejemplo, se definieron interfaces para la gestión de clientes, proveedores, inventario, ventas, etc.

D (Dependency Inversion Principle - Principio de Inversión de Dependencias): Se aplicó la inversión de dependencias utilizando la inyección de dependencias y la inversión de control para desacoplar los diferentes componentes del sistema. Esto facilita la prueba unitaria, la mantenibilidad y la escalabilidad del sistema.

### Uso del Patrón MVC:

El patrón Modelo-Vista-Controlador (MVC) se utilizó para organizar y estructurar el código del sistema de gestión comercial de manera modular y escalable. Se dividió el sistema en tres componentes principales

Modelo (Model): Representa la capa de datos del sistema, que incluye la lógica de negocio y la interacción con la base de datos. Por ejemplo, las clases que representan los objetos de negocio como clientes, productos, ventas, etc., se encuentran en esta capa.

Vista (View): Representa la capa de presentación del sistema, que muestra la información al usuario y recibe sus interacciones. Por ejemplo, las interfaces de usuario para la gestión de clientes, ventas, inventario, etc., se encuentran en esta capa.

Controlador (Controller): Actúa como intermediario entre el modelo y la vista, maneja las solicitudes del usuario, procesa la lógica de negocio y actualiza la vista según sea necesario. Por ejemplo, los controladores para gestionar las operaciones de CRUD (Crear, Leer, Actualizar, Eliminar) en los diferentes módulos del sistema se encuentran en esta capa.

----------------------------------------------------------------------------------------------------------------------------------------------------------

#### frmLogin --> Para ingresar al sistema se necesita un numero de documento y contraseña.
[![Captura-de-pantalla-2024-04-03-160147.png](https://i.postimg.cc/tJL7Q91R/Captura-de-pantalla-2024-04-03-160147.png)](https://postimg.cc/4HQXpkbj)

#### Mensaje de alerta que la licencia vencia y es necesario que se renueve.
[![Captura-de-pantalla-2024-04-03-161939.png](https://i.postimg.cc/CK13pkb7/Captura-de-pantalla-2024-04-03-161939.png)](https://postimg.cc/WdBWMDWq)

#### Modulos --> Los 6 primeros modulos estan bloqueados, solamanente personal autorizado puede ingresar y renovar
[![Captura-de-pantalla-2024-04-03-163548.png](https://i.postimg.cc/fbn8BdBk/Captura-de-pantalla-2024-04-03-163548.png)](https://postimg.cc/XrLKvrM0)

#### Configuracion/Negocio/Prefencias --> Estableces valores globales del sistema y la empresa
[![Captura-de-pantalla-2024-04-03-163750.png](https://i.postimg.cc/sXn9dG9Y/Captura-de-pantalla-2024-04-03-163750.png)](https://postimg.cc/qh3C2RFq)

#### Socios/Clientes/Gestión de Clientes --> ABM CLIENTES
[![Captura-de-pantalla-2024-04-03-164455.png](https://i.postimg.cc/Vv80djBQ/Captura-de-pantalla-2024-04-03-164455.png)](https://postimg.cc/XGsYPBzQ)

#### Inventario/Catalogo/Gestión de Productos --> Visor general de los productos que contiene el sistema
[![Captura-de-pantalla-2024-04-03-164727.png](https://i.postimg.cc/25HfqmQz/Captura-de-pantalla-2024-04-03-164727.png)](https://postimg.cc/CZf2t3rt)

#### Inventario/Comercio/Act Stock PVP individual --> Actualización rapida del stock de un producto mas el cambio de precio de venta al consumidor
[![Captura-de-pantalla-2024-04-03-165348.png](https://i.postimg.cc/L4QndKGF/Captura-de-pantalla-2024-04-03-165348.png)](https://postimg.cc/bdbzbMzm)

#### Ventas/Ventas/Punto de Ventas --> Registrador de Ventas
[![Captura-de-pantalla-2024-04-03-165656.png](https://i.postimg.cc/k5M23JM9/Captura-de-pantalla-2024-04-03-165656.png)](https://postimg.cc/5XG48MFk)
