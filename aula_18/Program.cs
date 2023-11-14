using System;
using System.Collections.Generic;

/* Exercício 1: Hierarquia Básica de Classes
class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico de animal");
    }
}

class Cachorro : Animal
{
    public Cachorro(string nome, int idade) : base(nome, idade) { }

    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

class Gato : Animal
{
    public Gato(string nome, int idade) : base(nome, idade) { }

    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }
}

class Program
{
    static void Main()
    {
        Animal animalGenerico = new Animal("Animal Genérico", 3);
        animalGenerico.EmitirSom();

        Cachorro cachorro = new Cachorro("Bob", 2);
        cachorro.EmitirSom();

        Gato gato = new Gato("Mia", 1);
        gato.EmitirSom();
    }
}*/


/*  Exercício 2: Construtores e Herança
class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico de animal");
    }
}

class Cachorro : Animal
{
    public Cachorro(string nome, int idade) : base(nome, idade) { }

    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

class Gato : Animal
{
    public Gato(string nome, int idade) : base(nome, idade) { }

    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }
}

class Program
{
    static void Main()
    {
        Animal animalGenerico = new Animal("Animal Genérico", 3);
        animalGenerico.EmitirSom();

        Cachorro cachorro = new Cachorro("Bob", 2);
        cachorro.EmitirSom();

        Gato gato = new Gato("Mia", 1);
        gato.EmitirSom();
    }
}*/


/* Exercício 3: Propriedades e Métodos Protegidos
class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    protected int NumeroDePatas { get; set; }

    public Animal(string nome, int idade, int numeroDePatas)
    {
        Nome = nome;
        Idade = idade;
        NumeroDePatas = numeroDePatas;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico de animal");
        ExibirNumeroDePatas();
    }

    protected void ExibirNumeroDePatas()
    {
        Console.WriteLine($"Número de patas: {NumeroDePatas}");
    }
}

class Cachorro : Animal
{
    public Cachorro(string nome, int idade) : base(nome, idade, 4) { }

    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
        base.EmitirSom(); // Chama o método da classe base para exibir o número de patas
    }
}

class Gato : Animal
{
    public Gato(string nome, int idade) : base(nome, idade, 4) { }

    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
        base.EmitirSom(); // Chama o método da classe base para exibir o número de patas
    }
}

class Program
{
    static void Main()
    {
        Animal animalGenerico = new Animal("Animal Genérico", 3, 0);
        animalGenerico.EmitirSom();

        Cachorro cachorro = new Cachorro("Bob", 2);
        cachorro.EmitirSom();

        Gato gato = new Gato("Mia", 1);
        gato.EmitirSom();
    }
}*/


/* Exercício 4: Polimorfismo com Coleções
class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    protected int NumeroDePatas { get; set; }

    public Animal(string nome, int idade, int numeroDePatas)
    {
        Nome = nome;
        Idade = idade;
        NumeroDePatas = numeroDePatas;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico de animal");
        ExibirNumeroDePatas();
    }

    protected void ExibirNumeroDePatas()
    {
        Console.WriteLine($"Número de patas: {NumeroDePatas}");
    }
}

class Cachorro : Animal
{
    public Cachorro(string nome, int idade) : base(nome, idade, 4) { }

    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
        base.EmitirSom();
    }
}

class Gato : Animal
{
    public Gato(string nome, int idade) : base(nome, idade, 4) { }

    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
        base.EmitirSom();
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animais = new List<Animal>();

        // Adicionando instâncias de Cachorro e Gato à lista
        animais.Add(new Cachorro("Bob", 2));
        animais.Add(new Gato("Mia", 1));
        animais.Add(new Cachorro("Buddy", 3));
        animais.Add(new Gato("Whiskers", 2));

        // Iterando sobre a lista e invocando o método EmitirSom() para cada animal
        foreach (Animal animal in animais)
        {
            Console.WriteLine($"Nome: {animal.Nome}, Idade: {animal.Idade}");
            animal.EmitirSom();
            Console.WriteLine();
        }
    }
}*/
