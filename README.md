# DesignPatterns

<h2>Creational Patterns:</h4>

<h5>Singleton: </h5>
<p>
  The Singleton Pattern ensures a class has only one instance and provides a global point of access to that instance. It is one of the 
  simplest design patterns, commonly used when exactly one object is needed to coordinate actions across the system.
</p>
<h5>Factory: </h5>
<h5>Abstract Factory : </h5>
<h5>Builder:  </h5>
<h5>Prototype: </h5>
<h5>Flyweight: </h5>
<h5>Proxy: </h5>


<h2>Structural Patterns:</h4>
<h5>Adapter: </h5>
<h5>Bridge: </h5>
<h5>Composite: </h5>
<h5>Decorator:  </h5>
<h5>Facade: </h5>
<h5>Flyweight: </h5>
<h5>Proxy: </h5>


<h2>Behavioral Patterns:</h2>

<h5>Chain of Responsibility: </h5>
<h5>Command:</h5>
<h5>Interpreter: </h5>
<h5>Iterator:  </h5>
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
<h5>Memento: </h5>
<h5>Observer: </h5>
<h5>State: </h5>
<h5>Strategy: </h5>
<h5>Template Method:  </h5>
<h5>Visitor:  </h5>


