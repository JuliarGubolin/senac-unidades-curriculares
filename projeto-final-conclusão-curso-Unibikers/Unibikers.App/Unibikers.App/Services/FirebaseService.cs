using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace Unibikers.App.Services
{
    public class FirebaseService
    {
        //https://tec46unibikers-default-rtdb.firebaseio.com/
        //https://unibikersapp-default-rtdb.firebaseio.com/

        public FirebaseClient firebaseDatabase =
            new FirebaseClient("https://tec46unibikers-default-rtdb.firebaseio.com/");
    }
}
