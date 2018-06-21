using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class AnimationSubstitute : Animation
    {
        Film film;
        Photo photo;
        AnimationSubstitute(Photo photo,Film film=null)
        {
            this.film = film;
            this.photo = photo;
        }
        public void click()
        {
            if (film == null) film = new Film();
            film.Run();
        }

        public void show()
        {
            if (film == null) photo.Show();
            else film.show();
        }
    }
}
