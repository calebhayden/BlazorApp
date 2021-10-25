using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class RetroBoardService
    {
        private static readonly string[] Ipsum = new[]
        {
            "I'm baby microdosing brunch synth drinking vinegar vexillologist food truck master cleanse live-edge pork belly.",
            "Keffiyeh pok pok taxidermy cold-pressed.  Tote bag +1 shaman brooklyn letterpress kogi.",
            "Readymade viral street art leggings jean shorts stumptown, 90's artisan tumblr.",
            "Ethical flannel try-hard, ugh next level keytar etsy post-ironic.",
            "Yr stumptown small batch kickstarter tattooed fashion axe taxidermy quinoa meh dreamcatcher single-origin coffee affogato hammock.",
            "Taiyaki tofu fanny pack trust fund.",
            "Sriracha keffiyeh fam literally pitchfork put a bird on it humblebrag. Offal kogi venmo narwhal fanny pack.",
            "Flannel master cleanse authentic, waistcoat 90's normcore artisan freegan twee scenester.",
            "Chambray sartorial poke skateboard irony kickstarter flannel DIY artisan.",
            "Green juice paleo master cleanse tumeric portland lo-fi unicorn truffaut food truck neutra plaid 8-bit.",
            "Plaid tousled tofu, cornhole subway tile distillery letterpress franzen.",
            "Hammock subway tile ugh cardigan, deep v affogato scenester keytar YOLO selvage poke polaroid.",
            "Leggings enamel pin VHS single-origin coffee, meh mumblecore drinking vinegar post-ironic sustainable tacos.",
            "Vexillologist retro readymade snackwave vape chia. Sartorial ethical plaid, hot chicken artisan literally snackwave paleo 90's hammock unicorn next level.",
            "ligma",
            "Tilde flexitarian woke quinoa, flannel blog stumptown intelligentsia twee jianbing pickled salvia."

        };

        public Task<List<RetroItem>> GetRetroBoardAsync()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, rng.Next(5)).Select(index => new RetroItem
            {
                Text = Ipsum[rng.Next(Ipsum.Length)]
            }).ToList());
        }
    }
}
