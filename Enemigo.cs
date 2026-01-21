public class Enemigo
{
    private int vida;

    public void RecibirDaño(int daño)
    {
        vida -= daño;
    }
}