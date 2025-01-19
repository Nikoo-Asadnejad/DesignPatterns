# DesignPatterns

Design patterns provide proven solutions to common software design problems. This repository is a comprehensive guide to understanding and applying design patterns using C#. 

Design Patterns Covered :
1. [Singleton](#singleton) :
   Ensure a class has only one instance and provide a global point of access to it.
3. [Factory Method](#factory-method) :
   Define an interface for creating an object, but let subclasses alter the type of objects that will be created.
5. [Abstract Factory](#abstract-factory)  :
   Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
7. [Builder](#builder) :
   Separate the construction of a complex object from its representation so that the same construction process can create different representations.
9. [Prototype](#prototype) :
    Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.
11. [Adapter](#adapter) :
    Convert the interface of a class into another interface clients expect.
13. [Bridge](#bridge) :
    Decouple an abstraction from its implementation so that the two can vary independently.
15. [Composite](#composite) :
    Compose objects into tree structures to represent part-whole hierarchies.
17. [Decorator](#decorator) :
    Attach additional responsibilities to an object dynamically.
19. [Facade](#facade) :
    Provide a unified interface to a set of interfaces in a subsystem.
21. [Flyweight](#flyweight) :
    Use sharing to support large numbers of fine-grained objects efficiently.
23. [Proxy](#proxy) :
    Use sharing to support large numbers of fine-grained objects efficiently.
25. [Chain of Responsibility](#chain-of-responsibility) :
    Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
27. [Command](#command) :
    Encapsulate a request as an object, thereby allowing for parameterization of clients with different requests.
29. [Interpreter](#interpreter) :
    Define a representation for a language’s grammar along with an interpreter that uses the representation to interpret sentences.
31. [Iterator](#iterator) :
    Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
33. [Mediator](#mediator) :
    Define an object that encapsulates how a set of objects interact.
35. [Memento](#memento) :
    Capture and externalize an object’s internal state so that the object can be restored to this state later.
37. [Observer](#observer) :
    Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated.
39. [State](#state) :
     Allow an object to alter its behavior when its internal state changes.
41. [Strategy](#strategy) :
    Define a family of algorithms, encapsulate each one, and make them interchangeable.
43. [Template Method](#template-method) :
    Define the skeleton of an algorithm in a method, deferring some steps to subclasses.
45. [Visitor](#visitor) :
    Represent an operation to be performed on elements of an object structure.


## Creational Patterns:

### Singleton: 
<p>
  The Singleton Pattern ensures a class has only one instance and provides a global point of access to that instance. It is one of the 
  simplest design patterns, commonly used when exactly one object is needed to coordinate actions across the system.
</p>

### Factory: 
<p>
 The Factory Pattern is a creational design pattern to create objects without specifying the exact class of the object that will be created. Instead of using a direct constructor call to create an object, you use a factory method to produce an instance of the class. This pattern promotes loose coupling and makes the code more flexible and scalable.
</p>

### Abstract Factory : 
<p>
The Abstract Factory pattern is a creational design pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes. It allows you to produce a variety of objects that are related by a common theme, without having to know or specify the exact classes of those objects.
</p>

### Builder: 
<p>
The Builder pattern is a creational design pattern that provides a way to construct complex objects step by step. It allows you to produce different types and representations of an object using the same construction process. The Builder pattern is especially useful when the construction of an object requires many steps or when there are many possible configurations for the object.
</p>

### Prototype: 
<p>
The Prototype pattern is a creational design pattern that allows you to create new objects by copying an existing object, known as a prototype, rather than by creating new instances through constructors. This pattern is particularly useful when the cost of creating a new object directly is expensive or complex.
</p>


## Structural Patterns
### Adapter: 
<p>
The Adapter pattern is a structural design pattern that allows incompatible interfaces to work together by converting the interface of a class into another interface that a client expects. This pattern acts as a bridge between two incompatible interfaces, making it possible for classes with different interfaces to collaborate.
</p>

When to Use the Adapter Pattern:
<li> When you have existing classes that you need to reuse but their interfaces are incompatible with the rest of your code.</li>	
<li> When you want to create a reusable class that cooperates with unrelated or unforeseen classes, that is, classes that do not necessarily have compatible interfaces.</li>	
<li> When you need to use several existing subclasses but it’s impractical to adapt their interfaces by subclassing each one.</li>	
 

### Bridge: 
<p>
The Bridge pattern is a structural design pattern that separates an abstraction from its implementation, allowing them to vary independently. This pattern is used to decouple an abstraction from its implementation so that the two can evolve separately without affecting each other. By using the Bridge pattern, you can avoid a permanent binding between an abstraction and its implementation, making your code more flexible and scalable.
</p>

When to Use the Bridge Pattern:
<li>When you want to avoid a permanent binding between an abstraction and its implementation, allowing both to vary independently.</li>
<li>When you have a class explosion problem because you have multiple dimensions of variation (e.g., you have classes that can vary in multiple ways).</li>
<li>When you want to share an implementation among multiple objects (using inheritance) and the inheritance hierarchy becomes too complex.</li>


### Composite: 
The Composite pattern is a structural design pattern used to compose objects into tree-like structures to represent part-whole hierarchies. It allows you to treat individual objects and compositions of objects uniformly. The Composite pattern enables clients to work with complex tree structures (comprising both individual objects and compositions) as if they were single objects, simplifying the client code.

When to Use the Composite Pattern:
<li>When you need to represent part-whole hierarchies of objects.</li>
<li>When you want clients to be able to ignore the difference between compositions of objects and individual objects.</li>
<li>When you need to work with tree structures, where you want to treat both individual objects and groups of objects in the same way.</li>

### Decorator: 

<p>
The Decorator pattern is a structural design pattern that allows you to dynamically add behavior or responsibilities to individual objects, either statically or at runtime, without affecting the behavior of other objects from the same class. It provides a flexible alternative to subclassing for extending functionality.
</p>

When to Use the Decorator Pattern:
<li>When you need to add responsibilities to individual objects dynamically and in a flexible way.</li>
<li>When subclassing would lead to a large number of classes due to the combinatorial explosion of possible feature combinations.</li>
<li>When you want to enhance the functionality of objects without altering their structure or affecting other objects of the same class.</li>

### Facade:
The Facade pattern is a structural design pattern that provides a simplified interface to a complex subsystem. It is used to hide the complexity of a system by providing a unified and simplified interface, making it easier for clients to interact with the subsystem without needing to understand its intricate details.

When to Use the Facade Pattern:
<li>When you need to provide a simplified and unified interface to a complex subsystem, making it easier to use.</li>
<li>When you want to decouple a client from a complex subsystem, promoting loose coupling and reducing dependencies.</li>
<li>When you want to improve the readability and maintainability of your code by hiding complex interactions behind a single interface.</li>
 
### Flyweight: 
<p>
The Flyweight pattern is a structural design pattern that enables the efficient sharing of objects to support large numbers of fine-grained objects without incurring the overhead of storing a large amount of data. It is used to minimize memory usage and improve performance by sharing as much data as possible with similar objects, rather than keeping separate copies of data for each object.
</p>

### Proxy:
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



## Behavioral Patterns:</h2>

### Chain of Responsibility:
The Chain of Responsibility design pattern is a behavioral design pattern used to process a request through a sequence of potential handlers. Each handler in the chain can either process the request, pass it along to the next handler, or stop further processing.

#### Key Characteristics:

1.Decoupling of Senders and Receivers: The pattern allows the sender of a request to pass it along a chain of handlers without needing to know which handler will ultimately process the request.
2.Dynamic Composition: Handlers can be added or removed dynamically at runtime, providing flexibility.
3.Request Handling: Each handler has the opportunity to:
- Process the request and stop further propagation.
- Partially handle the request and pass it to the next handler.
- Pass the request without handling it.

#### Structure:

1. Handler Interface/Abstract Class:
- Declares a method to handle the request.
- Optionally includes a reference to the next handler in the chain.
2. Concrete Handlers:
- Implement the handler interface or extend the abstract class.
- Decide whether to process the request or pass it to the next handler.
3. Client:
- Initiates the request by sending it to the first handler in the chain.

Advantages:
1.Flexibility: Handlers can be easily added, removed, or reordered.
2.Responsibility Sharing: Complex requests can be handled by splitting responsibilities across multiple handlers.
3.Open/Closed Principle: Adding new handlers doesn’t require modifying existing code.

Disadvantages:
1.Debugging Complexity: It can be harder to trace how a request is processed as it flows through the chain.
2.Potential Performance Hit: If the chain is long and no handler processes the request, performance may suffer.
 
### Command:

The Command design pattern is a behavioral design pattern used to encapsulate a request as an object, thereby allowing users to parameterize objects with different requests, delay or queue a request’s execution, and support undoable operations. It is commonly used in scenarios where you need to decouple the sender of a request from the receiver.

Key Concepts:
	1.	Command: An interface or abstract class that declares the method to execute the command.
	2.	ConcreteCommand: A class that implements the Command interface and defines the binding between a Receiver and an action.
	3.	Receiver: The object that performs the actual work when the command is executed.
	4.	Invoker: A class responsible for triggering the execution of commands. It can maintain a history of commands for undo/redo functionality.
	5.	Client: The class that creates and configures the command objects.

Structure:
	1.	Command Interface:
	•	Declares a method like execute() that all commands will implement.
	2.	ConcreteCommand:
	•	Implements the Command interface.
	•	Binds a receiver to an action.
	3.	Invoker:
	•	Triggers the command using the execute() method.
	4.	Receiver:
	•	Knows how to perform the actual operations associated with the request.


Use Cases:
	1.	Undo/Redo functionality (e.g., text editors, graphic applications).
	2.	Transaction management.
	3.	Macro recording (sequence of commands).
	4.	GUI buttons and menu actions.

Advantages:
	•	Decouples the sender and receiver of requests.
	•	Supports undo/redo operations easily.
	•	Enables extensibility by allowing new commands to be added without changing existing code.

Disadvantages:
	•	Can increase the complexity of the system with additional classes.

### Interpreter: 
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

### Iterator: 
<p>
The Iterator pattern is a behavioral design pattern that provides a way to access elements of a collection (like a list, array, or any aggregate object) sequentially, without exposing the underlying structure of the collection. This pattern is useful when you want to traverse through a collection without worrying about how it’s implemented, whether it’s an array, a linked list, or some other structure.

</p>
### Mediator:
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

### Memento: 
The Memento design pattern is a behavioral design pattern that allows you to capture and store the current state of an object so that it can be restored later, without exposing the internal structure of that object. 
It is typically used to implement undo mechanisms in applications.

</br>

**Key Components:**
- Originator: The object whose state is being saved or restored. The Originator creates a Memento containing a snapshot of its current state.
- Memento: Stores the internal state of the Originator. It doesn't expose its data to other objects, thus preserving encapsulation.
- Caretaker: Manages the Memento. The Caretaker requests a Memento from the Originator and stores it, but does not access or modify the state. It later uses the Memento to restore the Originator to its previous state.


### Observer: 

The Observer Pattern is a design pattern used in software engineering to establish a one-to-many dependency between objects. When the state of one object (the subject) changes, all its dependents (observers) are notified and updated automatically.

#### Key Components:

1. **Subject**: The object being observed. It maintains a list of observers and provides methods to attach and detach them.

2. **Observer**: An interface or abstract class defining the update method that will be called when the subject's state changes.

3. **ConcreteSubject**: A concrete implementation of the subject that maintains its state and notifies observers of changes.

4. **ConcreteObserver**: A concrete implementation of the observer that updates itself based on changes in the subject.

#### Use Cases:
- User interface components (e.g., updating UI elements in response to data changes).
- Event handling systems.
- Real-time systems (e.g., stock market updates).

#### Benefits:
- Promotes loose coupling between the subject and observers.
- Enhances scalability and maintainability.

### State: 
The State pattern is a behavioral design pattern that allows an object to alter its behavior when its internal state changes. It provides a way to encapsulate state-specific behavior and delegate behavior changes to the state objects themselves.
This pattern is particularly useful when an object can have multiple states, and its behavior needs to vary based on the current state. Instead of using a lot of conditional logic (e.g., if-else or switch statements), the State pattern organizes the behavior into separate state classes.

#### Key Components :
1.	**Context**:
	-	The main class whose behavior changes based on its current state.
	-	It holds a reference to a State object that represents its current state.
2.	**State Interface**:
	-	Defines a common interface for all possible states of the context.
	-	Each state implements this interface to provide its specific behavior.
3.	**Concrete States**:
	-	These are the specific implementations of the State interface.
	-	Each class represents a particular state and defines its behavior.

#### Use Cases:
1.	Game Development:
	-	Characters with different states like Idle, Walking, Running, Attacking.
	-	The state determines what actions the character can perform.
2.	Traffic Light System:
	-	A traffic light can be in Green, Yellow, or Red state.
	-	The behavior of transitioning lights is encapsulated in the state classes.
3.	Workflow Management:
	-	A document can be in states like Draft, UnderReview, Approved.
	-	Actions like editing, submitting, or publishing depend on the current state.
4.	Vending Machine:
	-	States like Idle, HasMoney, DispensingItem, OutOfStock.
	-	Each state controls valid operations for the vending machine.
5.	Authentication Flow:
	-	States such as LoggedOut, LoggedIn, Locked.
	-	Actions like Login, Logout, or Lock depend on the current state.

#### Benefits :
- Open/Closed Principle: Adding new states does not require changing the existing state logic.
- Simplifies Context Class: The context delegates the behavior to state objects, reducing its responsibilities.
- Easier to Understand: Each state has its own class, making it easier to manage and maintain.

#### Drawbacks :

- Increased Number of Classes: Each state requires a separate class, which can increase the complexity of the codebase.
- Tight Coupling: Context and state classes are tightly coupled, as context often needs to know about all states.
- Overhead: If there are very few states or if state transitions are rare, the overhead of implementing this pattern might not be justified.

#### When to Use: 
-	When an object’s behavior depends on its state and changes dynamically.
-	When you need to eliminate large if-else or switch statements for state-dependent behavior.
-	When state-specific behavior needs to be reused or extended easily.



### Strategy: 
The Strategy Pattern is a behavioral design pattern that enables selecting an algorithm’s behavior at runtime. Instead of implementing a single algorithm directly, the code defines a family of algorithms, encapsulates each one as a separate class, and makes them interchangeable. The Strategy pattern lets you swap the algorithm or logic used within an object without altering the client code.

#### Use Cases:
- When you have multiple ways to perform a task and want to switch between them easily.
- When you need to avoid conditional logic (if, switch) to select the algorithm.
- When you want to separate the algorithm logic from the context (the object using the algorithm).
  
### Template Method:  

### Visitor: 
The Visitor pattern is a behavioral design pattern that allows you to add further operations to objects without modifying their structure. It does this by separating operations from the objects on which they operate. The pattern involves creating a Visitor interface with visit methods for each type in an object structure. Classes that want to support new operations “accept” a visitor, allowing it to perform actions on them. This pattern is especially useful when you want to add new operations to classes that have an existing hierarchy without modifying the classes themselves.

#### Key Components :

1.	Visitor Interface: Defines methods for each concrete type in the hierarchy. Each visit method represents an operation that can be performed on that type.
2.	Concrete Visitor: Implements the Visitor interface, providing specific implementations of each visit method. These are the actual operations performed on elements in the object structure.
3.	Element Interface: Declares an accept method that takes a Visitor as an argument. This method allows a visitor to access the element.
4.	Concrete Elements: Implement the Element interface and the accept method. When accept is called, it passes the current instance to the visitor’s corresponding visit method.
5.	Object Structure: Usually a collection of elements, such as a list or tree, that can be iterated over. Each element in the structure “accepts” a visitor, which performs its operation.

#### Benefits:
-	Open/Closed Principle: You can add new operations without changing the existing class structure.
-  Single Responsibility Principle: Operation logic is extracted from classes, reducing their responsibilities.
-	Extensibility: Adding new visitors is straightforward and does not require modifying existing elements.

  #### Drawbacks:
-  Dependency on Object Structure: The visitor depends on specific elements in the structure, so changing the element hierarchy can require updates to all visitors.
-  Difficulty with Encapsulation: If certain internal states of elements need to be protected, exposing them to visitors can violate encapsulation.

#### Use Case:
1. Syntax Tree Traversal in Compilers
2. File System Operations
3. Validation Frameworks
4. Game Development


