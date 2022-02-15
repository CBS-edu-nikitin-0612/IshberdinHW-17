
/// <summary>
/// Создать класс Note, представляющий музыкальную ноту. Класс Note должен содержать следующие данные: частота, продолжительность в миллисекундах и значение типа bool, указывающее, является ли нота паузой. Создать 7 фабричных методов для создания нот (до, ре, ми, фа, соль, ля, си), фабричные методы в качестве параметров должны принимать номер октавы для соответствующей ноты и значение продолжительности в миллисекундах. Создать статический класс MelodyParser с методом для преобразовния строки из цифр и пробелов в массив нот: Note[] ParseMelody(string melody). Цифры от 0 до 9 соответствуют 10 последовательным нотам на Ваше усмотрение, пробел – паузе. Продолжительность звучания нот одинаковая и устанавливается на Ваше усмотрение.
///Создать статический класс Player с методом для последовательного воспроизведения массива нот с помощью метода Console.Beep:
///void Play(Note[] notes).
///Пример использования описанных классов:
///string melody = "987 876 765 654 543 432 111 8";
///Note[] notes = MelodyParser.ParseMelody(melody);
///Player.Play(notes);
/// </summary>
namespace Task2
{
    class Program
    {
        public static void Main()
        {
            string melody = "987 876 765 654 543 432 111 8";
            Note[] notes = MelodyParser.ParseMelody(melody);
            Player.Play(notes);
        }
    }
    static class Player
    {
        public static void Play(Note[] notes)
        {
            foreach (Note note in notes)
            {
                if (note.Freq < 37)
                    Console.Beep(37, 300);
                else if (note.Freq > 32767) Console.Beep(note.Freq, 32767);
                else Console.Beep(note.Freq, 300);
            }
        }
    }
    class Note
    {
        public int Freq { get; set; }
        public Note(int freq)
        {
            Freq = freq;
        }
    }
    class MelodyParser
    {
        public static Note[] ParseMelody(string melody)
        {
            int count;
            string[] strNotes = melody.Split(' ');
            count = strNotes.Length;
            Note[] notes = new Note[count];
            for (int i = 0; i < count; i++)
            {
                notes[i] = new Note(Convert.ToInt32(strNotes[i]));
            }
            return notes;
        }
    }
}