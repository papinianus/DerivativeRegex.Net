namespace DerivativeRegex;

public class Or(RegularExpression left, RegularExpression right) : RegularExpression
{
    private RegularExpression Left { get; } = left;
    private RegularExpression Right { get; } = right;

    // OR
    public override bool HasEpsilon() => Left.HasEpsilon() || Right.HasEpsilon();

    // 与えられた文字を左右どちらにも微分した結果を OR にする。文字がどちらかの側で受理されれば epsilon で両方で受理できなければ空集合
    public override RegularExpression Derive(char c) => new Or(Left.Derive(c), Right.Derive(c));
}
