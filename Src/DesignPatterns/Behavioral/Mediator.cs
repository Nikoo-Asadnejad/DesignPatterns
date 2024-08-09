namespace DesignPatterns;

using System;
using System.Collections.Generic;


   // The Mediator interface declares a method used by components to notify the
    // mediator about various events. The Mediator may react to these events and
    // pass the execution to other components.
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }

    // Concrete Mediators implement cooperative behavior by coordinating several
    // components.
    class ConcreteMediator : IMediator
    {
        private Component1 _component1;

        private Component2 _component2;

        public ConcreteMediator(Component1 component1, Component2 component2)
        {
            this._component1 = component1;
            this._component1.SetMediator(this);
            this._component2 = component2;
            this._component2.SetMediator(this);
        } 

        public void Notify(object sender, string ev)
        {
            if (ev == "A")
            {
                Console.WriteLine("Mediator reacts on A and triggers following operations:");
                this._component2.DoC();
            }
            if (ev == "D")
            {
                Console.WriteLine("Mediator reacts on D and triggers following operations:");
                this._component1.DoB();
                this._component2.DoC();
            }
        }
    }

    // The Base Component provides the basic functionality of storing a
    // mediator's instance inside component objects.
    class BaseComponent
    {
        protected IMediator _mediator;

        public BaseComponent(IMediator mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }

    // Concrete Components implement various functionality. They don't depend on
    // other components. They also don't depend on any concrete mediator
    // classes.
    class Component1 : BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Component 1 does A.");

            this._mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("Component 1 does B.");

            this._mediator.Notify(this, "B");
        }
    }

    class Component2 : BaseComponent
    {
        public void DoC()
        {
            Console.WriteLine("Component 2 does C.");

            this._mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("Component 2 does D.");

            this._mediator.Notify(this, "D");
        }
    }


// Mediator Interface
public interface IChatRoomMediator
{
    void SendMessage(string message, User user);
    void RegisterUser(User user);
}

// Concrete Mediator
public class ChatRoom : IChatRoomMediator
{
    private Dictionary<string, User> _users = new Dictionary<string, User>();

    public void RegisterUser(User user)
    {
        if (!_users.ContainsKey(user.Name))
        {
            _users[user.Name] = user;
        }

        user.SetChatRoom(this);
    }

    public void SendMessage(string message, User user)
    {
        foreach (var u in _users.Values)
        {
            // Don't send the message to the sender
            if (u != user)
            {
                u.Receive(message);
            }
        }
    }
}

// Colleague Class
public class User
{
    public string Name { get; private set; }
    private IChatRoomMediator _chatRoom;

    public User(string name)
    {
        Name = name;
    }

    public void SetChatRoom(IChatRoomMediator chatRoom)
    {
        _chatRoom = chatRoom;
    }

    public void Send(string message)
    {
        Console.WriteLine($"{Name} sends: {message}");
        _chatRoom.SendMessage(message, this);
    }

    public void Receive(string message)
    {
        Console.WriteLine($"{Name} receives: {message}");
    }
}

// Program Class to Test the Mediator Pattern
public class MediatorSample
{
    public static void Usage(string[] args)
    {
        // Create the mediator
        IChatRoomMediator chatRoom = new ChatRoom();

        // Create users and register them to the chat room
        User user1 = new User("Alice");
        User user2 = new User("Bob");
        User user3 = new User("Charlie");

        chatRoom.RegisterUser(user1);
        chatRoom.RegisterUser(user2);
        chatRoom.RegisterUser(user3);

        // Users send messages
        user1.Send("Hello, everyone!");
        user2.Send("Hi, Alice!");
        user3.Send("Good morning, all!");

        Console.ReadLine(); // To keep the console open
    }
}


