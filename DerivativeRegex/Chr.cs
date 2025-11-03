namespace DerivativeRegex;

public class Chr(char c) : RegularExpression
{
    private char Value { get; } = c;

    // 文字は epsilon ではない
    public override bool HasEpsilon() => false;
    
    // Char の Regex を c で微分するとき、c が Char そのものであれば epsilon 、そうでなければ空集合となる
    public override RegularExpression Derive(char c) => Value == c ? new Epsilon() : new EmptySet();
}