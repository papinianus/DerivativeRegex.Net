namespace DerivativeRegex;

public class Concat(RegularExpression left, RegularExpression right) : RegularExpression
{
    private RegularExpression Left { get; } = left;
    private RegularExpression Right { get; } = right;

    // 連接なので左側と右側の AND
    public override bool HasEpsilon() => Left.HasEpsilon() && Right.HasEpsilon();

    // TODO: 解釈を確認
    public override RegularExpression Derive(char c)
    {
        if (!Left.HasEpsilon())
        {
            return new Concat(Left.Derive(c), Right);
        }

        return new Or(new Concat(Left.Derive(c), Right), Right.Derive(c));
    }
}
