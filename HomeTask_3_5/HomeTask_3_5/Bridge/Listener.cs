namespace HomeTask_3_5.Bridge
{
    public abstract class Listener
    {
        protected IMusicBox genre;

        public Listener(IMusicBox gen)
        {
            genre = gen;
        }

        public IMusicBox Genre
        {
            set { genre = value; }
        }

        public virtual void Listen()
        {
            genre.Play();
        }

        public virtual void StopListening()
        {
            genre.Stop();
        }
    }
}
