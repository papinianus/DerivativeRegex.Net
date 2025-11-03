namespace DerivativeRegex;

public class Concat(RegularExpression left, RegularExpression right) : RegularExpression
{
    private RegularExpression Left { get; } = left;
    private RegularExpression Right { get; } = right;

    public override bool HasEpsilon() => Left.HasEpsilon() && Right.HasEpsilon();

    public override RegularExpression Derive(char c)
    {
        if (!Left.HasEpsilon())
        {
            return new Concat(Left.Derive(c), Right);
        }

        return new Or(new Concat(Left.Derive(c), Right), Right.Derive(c));
    }
}
/*
 *   def derive(self, c: str) -> Regex:
     if self.l1.is_contain_eps():
       left = Concat(self.l1.derive(c), self.l2)
       right = self.l2.derive(c)
       return Or(left, right)
     else:
       return Concat(self.l1.derive(c), self.l2)
     
 */