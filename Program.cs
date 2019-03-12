using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ActionMovieFactory action = new ActionMovieFactory();
            IBollywoodMovie BAction = action.GetBollywoodMovie();
            ITollywoodMovie TAction = action.GetTollywoodMovie();

            ComedyMovieFactory c = new ComedyMovieFactory();
            IBollywoodMovie BC = c.GetBollywoodMovie();
            ITollywoodMovie TC = c.GetTollywoodMovie();

        }
    }

    interface IBollywoodMovie
    {
        string MovieName { get; set; }
    }

    interface ITollywoodMovie
    {
        string MovieName { get; set; }
    }

    interface IMovieFactory
    {
        IBollywoodMovie GetBollywoodMovie();
        ITollywoodMovie GetTollywoodMovie();
    }

    //Action and Comedy Movie of Bollywood
    public class ActionBollywoodMovie : IBollywoodMovie
    {
        public string MovieName{ get; set; }
    }
    public class ComedyBollywoodMovie : IBollywoodMovie
    {
        public string MovieName { get; set; }
    }
    
    //Action and Comedy Movie of Tollywood
    public class ActionTollywoodMovie : ITollywoodMovie
    {
        public string MovieName { get; set; }
    }
    public class ComedyTollywoodMovie : ITollywoodMovie
    {
        public string MovieName { get; set; }
    }

    //Action MovieFactory and Comedy Movie Factory
    class ActionMovieFactory : IMovieFactory
    {
        public IBollywoodMovie GetBollywoodMovie()
        {
            throw new NotImplementedException();
        }

        public ITollywoodMovie GetTollywoodMovie()
        {
            throw new NotImplementedException();
        }
    }
    class ComedyMovieFactory:IMovieFactory
    {
        public IBollywoodMovie GetBollywoodMovie()
        {
            throw new NotImplementedException();
        }

        public ITollywoodMovie GetTollywoodMovie()
        {
            throw new NotImplementedException();
        }
    }
}
