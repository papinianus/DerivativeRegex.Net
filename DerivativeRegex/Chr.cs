namespace DerivativeRegex;

public class Chr(char c) : RegularExpression
{
    private char Value { get; } = c;

    public override bool HasEpsilon() => false;
    public override RegularExpression Derive(char c) => Value == c ? new Epsilon() : new EmptySet();
}