using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

class Program
{
    static void Main()
    {
        var code = @"
            class TestClass
            {
                void TestMethod()
                {
                    int i;
                }
            }";

        var syntaxTree = CSharpSyntaxTree.ParseText(code);
        var diagnostics = syntaxTree.GetDiagnostics();

        if (diagnostics.Any())
        {
            // unsuccessful parsing (errors or warnings)
            foreach (var diagnostic in diagnostics)
            {
                Console.WriteLine(diagnostic.ToString());
            }
        }
        else
        {
            // successful parsing
            Console.WriteLine("successful parsing");
            SyntaxNode rootSyntaxNode = syntaxTree.GetRoot();
            DisplayNodes(rootSyntaxNode, 1);
        }
    }

    static void DisplayMethodDeclaration(SyntaxNode syntaxNode)
    {
        Console.Write("{0} {1}", syntaxNode.ToString(), 
                                    syntaxNode.Span);

        IEnumerable<SyntaxNode> childNodes = syntaxNode.ChildNodes();

        if (childNodes.Count() == 0)
        {
            Console.WriteLine(" {0}", syntaxNode);
        }
        else
        {
            Console.WriteLine();   // end the line displayed with Write
            foreach (SyntaxNode childNode in childNodes)
            {
                if (childNode.Kind().ToString() == "MethodDeclaration") {
                    Console.WriteLine("\tMethodDeclaration");
                } else {
                }
            }
        }
    }

    static void DisplayClassDeclaration(SyntaxNode syntaxNode)
    {
       
        Console.Write("{0} {1}", syntaxNode.Kind(), 
                                    syntaxNode.Span);

        IEnumerable<SyntaxNode> childNodes = syntaxNode.ChildNodes();

        if (childNodes.Count() == 0)
        {
            //Console.WriteLine(" {0}", syntaxNode);
        }
        else
        {
            Console.WriteLine();   // end the line displayed with Write
            foreach (SyntaxNode childNode in childNodes)
            {
                if (childNode.Kind().ToString() == "MethodDeclaration") {
                    DisplayMethodDeclaration(syntaxNode);
                } else {
                }
            }
        }
    }

    static void DisplayNodes(SyntaxNode syntaxNode, int indent = 0)
    {
        IEnumerable<SyntaxNode> childNodes = syntaxNode.ChildNodes();

        if (childNodes.Count() == 0)
        {
            Console.WriteLine(" {0}", syntaxNode);
        }
        else
        {
            Console.WriteLine();   // end the line displayed with Write
            foreach (SyntaxNode childNode in childNodes)
            {
                if (childNode.Kind().ToString() == "ClassDeclaration") {
                    DisplayClassDeclaration(childNode);
                } else {
                    DisplayNodes(childNode, indent + 1);
                }
            }
        }
    }
}
