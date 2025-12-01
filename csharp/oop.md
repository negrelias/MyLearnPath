Aqui vai uma explicação **simples, clara e com exemplos do mundo real** para entender os **4 pilares da Programação Orientada a Objetos (POO)** usando **C#**.

---

# 🧱 Os 4 Pilares da POO com exemplos do mundo real

## 1️⃣ **Encapsulation (Encapsulamento)**

**Ideia:** Proteger dados internos e controlar como eles são acessados ou modificados.

### 🔍 Exemplo do mundo real

Pense em uma **conta bancária**:

* Você não vê como o banco calcula taxas internamente.
* Você só usa métodos controlados: *Depositar()* e *Sacar()*.
  Isso evita erros e mantém a segurança.

### 💻 Em C#

```csharp
public class ContaBancaria
{
    private decimal saldo; // DADO PROTEGIDO

    public void Depositar(decimal valor)
    {
        saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor <= saldo)
            saldo -= valor;
    }

    public decimal ObterSaldo()
    {
        return saldo; // acesso controlado
    }
}
```

---

## 2️⃣ **Inheritance (Herança)**

**Ideia:** Permitir que uma classe herde características e comportamentos de outra.

### 🔍 Exemplo do mundo real

Um **Carro** e uma **Moto** são tipos de **Veículo**:

* Todo veículo tem *marca*, *modelo*, *ano*.
* Mas cada um tem comportamentos específicos.

### 💻 Em C#

```csharp
public class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public void Ligar()
    {
        Console.WriteLine("Veículo ligado!");
    }
}

public class Carro : Veiculo
{
    public int NumeroDePortas { get; set; }
}

public class Moto : Veiculo
{
    public bool TemPartidaEletrica { get; set; }
}
```

---

## 3️⃣ **Polymorphism (Polimorfismo)**

**Ideia:** Um mesmo método pode ter comportamentos diferentes dependendo do objeto.

### 🔍 Exemplo do mundo real

Imagine uma função *Dirigir()*:

* Dirigir um **carro** é diferente de dirigir uma **moto**.
* A ação é a mesma (“dirigir”), mas com comportamentos distintos.

### 💻 Em C#

```csharp
public class Veiculo
{
    public virtual void Dirigir()
    {
        Console.WriteLine("Dirigindo um veículo...");
    }
}

public class Carro : Veiculo
{
    public override void Dirigir()
    {
        Console.WriteLine("Dirigindo um carro...");
    }
}

public class Moto : Veiculo
{
    public override void Dirigir()
    {
        Console.WriteLine("Dirigindo uma moto...");
    }
}
```

### Uso:

```csharp
Veiculo v1 = new Carro();
Veiculo v2 = new Moto();

v1.Dirigir(); // Dirigindo um carro...
v2.Dirigir(); // Dirigindo uma moto...
```

---

## 4️⃣ **Abstraction (Abstração)**

**Ideia:** Esconder a complexidade e mostrar apenas o essencial.

### 🔍 Exemplo do mundo real

Um **controle remoto**:

* Você aperta “Aumentar Volume”.
* Não precisa aprender eletrônica para usar.
  A abstração simplifica o uso.

### 💻 Em C#

```csharp
public abstract class Pagamento
{
    public abstract void Pagar(decimal valor); // só define, não implementa
}

public class PagamentoCartao : Pagamento
{
    public override void Pagar(decimal valor)
    {
        Console.WriteLine($"Pagando {valor} no cartão...");
    }
}

public class PagamentoPix : Pagamento
{
    public override void Pagar(decimal valor)
    {
        Console.WriteLine($"Pagando {valor} via PIX...");
    }
}
```

---

# 🎯 Resumo rápido

| Pilar             | Explicação                              | Exemplo                |
| ----------------- | --------------------------------------- | ---------------------- |
| **Encapsulation** | Proteger dados e controlar acesso       | Conta bancária         |
| **Inheritance**   | Reutilizar código de classes base       | Carro herda de Veículo |
| **Polymorphism**  | Mesmo método, comportamentos diferentes | Dirigir carro/moto     |
| **Abstraction**   | Mostrar só o essencial                  | Pagamento abstrato     |
