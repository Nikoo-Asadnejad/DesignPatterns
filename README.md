# DesignPatterns

<h2>Creational Patterns:</h4>

<h4>Singleton: </h4>
<p>
  The Singleton Pattern ensures a class has only one instance and provides a global point of access to that instance. It is one of the 
  simplest design patterns, commonly used when exactly one object is needed to coordinate actions across the system.
</p>

<h4>Factory: </h4>
<p>
 The Factory Pattern is a creational design pattern to create objects without specifying the exact class of the object that will be created. Instead of using a direct constructor call to create an object, you use a factory method to produce an instance of the class. This pattern promotes loose coupling and makes the code more flexible and scalable.
</p>

<h4>Abstract Factory : </h4>
<p>
The Abstract Factory pattern is a creational design pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes. It allows you to produce a variety of objects that are related by a common theme, without having to know or specify the exact classes of those objects.
</p>

<h4>Builder:  </h4>
<p>
The Builder pattern is a creational design pattern that provides a way to construct complex objects step by step. It allows you to produce different types and representations of an object using the same construction process. The Builder pattern is especially useful when the construction of an object requires many steps or when there are many possible configurations for the object.
</p>

<h4>Prototype: </h4>
<p>
The Prototype pattern is a creational design pattern that allows you to create new objects by copying an existing object, known as a prototype, rather than by creating new instances through constructors. This pattern is particularly useful when the cost of creating a new object directly is expensive or complex.
</p>


<h2>Structural Patterns:</h4>
<h4>Adapter: </h4>
<p>
The Adapter pattern is a structural design pattern that allows incompatible interfaces to work together by converting the interface of a class into another interface that a client expects. This pattern acts as a bridge between two incompatible interfaces, making it possible for classes with different interfaces to collaborate.
</p>

When to Use the Adapter Pattern:
<li> When you have existing classes that you need to reuse but their interfaces are incompatible with the rest of your code.</li>	
<li> When you want to create a reusable class that cooperates with unrelated or unforeseen classes, that is, classes that do not necessarily have compatible interfaces.</li>	
<li> When you need to use several existing subclasses but it’s impractical to adapt their interfaces by subclassing each one.</li>	
 

<h4>Bridge: </h4>
<p>
The Bridge pattern is a structural design pattern that separates an abstraction from its implementation, allowing them to vary independently. This pattern is used to decouple an abstraction from its implementation so that the two can evolve separately without affecting each other. By using the Bridge pattern, you can avoid a permanent binding between an abstraction and its implementation, making your code more flexible and scalable.
</p>

When to Use the Bridge Pattern:
<li>When you want to avoid a permanent binding between an abstraction and its implementation, allowing both to vary independently.</li>
<li>When you have a class explosion problem because you have multiple dimensions of variation (e.g., you have classes that can vary in multiple ways).</li>
<li>When you want to share an implementation among multiple objects (using inheritance) and the inheritance hierarchy becomes too complex.</li>


<h4>Composite: </h4>
The Composite pattern is a structural design pattern used to compose objects into tree-like structures to represent part-whole hierarchies. It allows you to treat individual objects and compositions of objects uniformly. The Composite pattern enables clients to work with complex tree structures (comprising both individual objects and compositions) as if they were single objects, simplifying the client code.

When to Use the Composite Pattern:
<li>When you need to represent part-whole hierarchies of objects.</li>
<li>When you want clients to be able to ignore the difference between compositions of objects and individual objects.</li>
<li>When you need to work with tree structures, where you want to treat both individual objects and groups of objects in the same way.</li>

<h4>Decorator:  </h4>

<p>
The Decorator pattern is a structural design pattern that allows you to dynamically add behavior or responsibilities to individual objects, either statically or at runtime, without affecting the behavior of other objects from the same class. It provides a flexible alternative to subclassing for extending functionality.
</p>

When to Use the Decorator Pattern:
<li>When you need to add responsibilities to individual objects dynamically and in a flexible way.</li>
<li>When subclassing would lead to a large number of classes due to the combinatorial explosion of possible feature combinations.</li>
<li>When you want to enhance the functionality of objects without altering their structure or affecting other objects of the same class.</li>

<h4>Facade: </h4>
The Facade pattern is a structural design pattern that provides a simplified interface to a complex subsystem. It is used to hide the complexity of a system by providing a unified and simplified interface, making it easier for clients to interact with the subsystem without needing to understand its intricate details.

When to Use the Facade Pattern:
<li>When you need to provide a simplified and unified interface to a complex subsystem, making it easier to use.</li>
<li>When you want to decouple a client from a complex subsystem, promoting loose coupling and reducing dependencies.</li>
<li>When you want to improve the readability and maintainability of your code by hiding complex interactions behind a single interface.</li>
 
<h4>Flyweight: </h4>
<p>
The Flyweight pattern is a structural design pattern that enables the efficient sharing of objects to support large numbers of fine-grained objects without incurring the overhead of storing a large amount of data. It is used to minimize memory usage and improve performance by sharing as much data as possible with similar objects, rather than keeping separate copies of data for each object.
</p>

<h4>Proxy: </h4>
<p>
The Proxy pattern is a structural design pattern that provides a surrogate or placeholder for another object to control access to it. The proxy object acts as an intermediary that represents the actual object, allowing you to add additional behavior or manage access to the original object without modifying its code.
</p>

When to Use the Proxy Pattern  :

<li>When you need to control access to a resource or object, such as with access control or authorization.</li>
<li>When you need to add additional behavior to an object, such as logging, caching, or lazy loading, without modifying the object itself.</li>
<li>When the actual object is resource-intensive to create or use, and you want to delay its creation or initialization until it’s actually needed.</li>
</br>

Types of Proxies:
<ol>
  <li> Virtual Proxy: Manages the creation and initialization of expensive objects. It acts as a stand-in and creates the real object only when it is needed.</li>
<li> Remote Proxy: Represents an object that exists in a different address space (e.g., a different machine or network). It handles communication between the client and the remote object. </li>
<li>	Protection Proxy: Controls access to the real object, typically used for access control or authentication.</li>
<li>	Smart Proxy: Adds additional behavior when accessing the real object, such as reference counting, logging, or access monitoring.</li>
</ol>



<h2>Behavioral Patterns:</h2>

<h4>Chain of Responsibility: </h4>
<h4>Command:</h4>
<h4>Interpreter: </h4>
<p>
The Interpreter pattern is a behavioral design pattern that defines a representation for a language’s grammar and provides an interpreter to process sentences in that language. This pattern is typically used to interpret expressions from languages with a defined grammar, such as mathematical expressions or simple scripting languages.
The pattern is most useful when you need to evaluate or process expressions that can be defined in terms of a language or grammar. It works well for small languages where defining formal grammar rules and interpreting them is straightforward.
</p>

Advantages of the Interpreter Pattern :
- Flexibility: It provides an easy way to extend the grammar by adding new expression classes.
- Modularity: Each rule in the grammar is represented by a different class, making the design modular and easy to maintain.
- Reusability: Each expression (terminal or non-terminal) is reusable in different contexts and combinations.

Disadvantages of the Interpreter Pattern :
- Performance: It can become inefficient and slow if the language grammar is complex or the number of expressions grows large, as it requires recursive interpretation.
- Scalability: The pattern works best for small, simple languages or expressions. As the grammar grows, the number of classes increases, leading to higher complexity.

When to use Interpreter Pattern:
-	Scripting languages: Small custom scripting languages where the grammar can be defined easily.
- Compilers/Interpreters: Parts of compilers or interpreters that parse and execute expressions.
- SQL/Mathematical Expression Evaluators: Systems that need to interpret mathematical formulas, queries, or commands.
- Configuration/Rule Engines: Applications that allow users to define rules in a specific language and then interpret and execute them.

<h4>Iterator:  </h4>
<p>
The Iterator pattern is a behavioral design pattern that provides a way to access elements of a collection (like a list, array, or any aggregate object) sequentially, without exposing the underlying structure of the collection. This pattern is useful when you want to traverse through a collection without worrying about how it’s implemented, whether it’s an array, a linked list, or some other structure.

</p>
<h4>Mediator: </h4>
<p>
The Mediator pattern is a behavioral design pattern that aims to reduce the complexity of communication between multiple objects by introducing a mediator object. 
The mediator centralizes the communication logic, allowing objects (often referred to as “colleagues”) to interact indirectly through the mediator rather than directly with each other.
</p>

<h5>Why Use the Mediator Pattern?</h5>
1.	Reduced Coupling:
<li>	Without Mediator: If objects communicate directly with each other, they become tightly coupled. Each object needs to know about the others, leading to a web of dependencies. This makes the system harder to maintain and evolve.</li>
<li>	With Mediator: Objects are decoupled from each other and only depend on the mediator. This means you can change the interaction logic in one place (the mediator) without affecting the individual objects.</li>
2.	Improved Maintainability:
<li>	As the number of interacting objects increases, the complexity of managing their relationships grows exponentially. The mediator centralizes this logic, making it easier to manage, debug, and extend.</li>
<li>	Adding new types of interactions or modifying existing ones can be done by changing the mediator, without needing to alter the objects themselves.</li>
3.	Simplified Communication Logic:
<li>	With direct communication, each object needs to handle its own messaging and coordination logic. This can lead to duplication of code and complex interactions.</li>
<li>	The mediator takes over this role, ensuring a consistent way of handling communications. The objects themselves become simpler since they delegate this responsibility to the mediator.</li>
4.	Flexibility and Extensibility:
<li>	By centralizing communication, you can more easily introduce new communication rules or modify existing ones without touching the rest of your system.</li>
<li>	You can introduce new objects or modify existing ones without worrying about how they’ll communicate with others directly. Instead, you just modify or extend the mediator.</li>
5.	Prevents Chaotic Interactions:
<li>	In complex systems, having objects communicate freely can lead to chaotic and unpredictable behavior. The mediator enforces a structure, ensuring that communication follows certain rules and patterns.</li>
<h4>Memento: </h4>
<h4>Observer: </h4>
<h4>State: </h4>
<h4>Strategy: </h4>
<h4>Template Method:  </h4>
<h4>Visitor:  </h4>


