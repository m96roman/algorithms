using System.IO;

namespace Algotester.Domain
{
    public interface IProblemSolver
    {
        void Solve(TextReader reader, TextWriter writer);
    }
}
