string oper = ">>";
System.Console.WriteLine("Operator: " + oper);
switch (oper)
{
    case "+":
    case "-":
        System.Console.WriteLine("Aditive operator");
        break;
    case "*":
    case "/":
        System.Console.WriteLine("Multiplicative operator");
        break;
    case "<":
    case ">":
    case "==":
        System.Console.WriteLine("Relational operator");
        break;
    case ">>":
    case "<<":
    case ">>>":
    case "|":
    case "&":
    case "~":
    case "^":
        System.Console.WriteLine("Bitwise operator");
        break;
    default:
        System.Console.WriteLine("Unknown operator");
        break;
}
System.Console.WriteLine("---");


