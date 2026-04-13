using System.Media;

public class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            // Find the greeting.wav file that was copied to the output folder
            string wavPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");

            using SoundPlayer player = new SoundPlayer(wavPath);
            Console.WriteLine("🎤 Playing voice greeting...");
            player.PlaySync();                    // Plays and waits until finished
            Console.WriteLine("✅ Voice greeting finished.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠️ Could not play greeting: {ex.Message}");
            Console.WriteLine("Make sure greeting.wav is in the project folder.\n");
        }
    }
}