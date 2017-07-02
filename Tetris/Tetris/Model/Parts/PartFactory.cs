using System;
using System.Dynamic;
using System.Linq;

namespace Tetris.Model
{
    public class PartFactory
    {
        public Part RandomPart()
        {
            var values = Enum.GetValues(typeof(PartType));
            var part = (PartType)values.GetValue(new Random().Next(values.Length));
            return CreatePart(part);
        }

        private Part CreatePart(PartType type)
        {
            switch (type)
            {
                case PartType.I:
                    return new I();
                case PartType.O:
                    return new O();
                case PartType.T:
                    return new T();
                case PartType.S:
                    return new S();
                case PartType.Z:
                    return new Z();
                case PartType.L:
                    return new L();
                case PartType.J:
                    return new J();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}