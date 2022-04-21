/* Canary.CSharp | embeds */

using System;
using CanaryAPI;

namespace Canary
{

    public partial class embeds : Class
    {

        object embed;
        object EmbedDateIntent;
        object EmbedTextBox;

        bool isFinishedLoading = false;

        public embedsMain(object sender, /* EventArgs e */)
        {

            embed = CanaryAPI.embedObject();
            EmbedDateIntent = CanaryAPI.embed.Properties.DateTimePicker();
            EmbedTextBox = CanaryAPI.embed.Properties.EmbedTextBox();

            CanaryAPI.createObject(embed);

            embed.AddProperties("Title" += embed.Properties.Title, "Icon" += embed.Properties.Title, "Description" += embed.Properties.Description && embed.Properties.enableMultiLine = true, "Section Field" += embed.Properties.Field, "Footer" += embed.Properties.Footer, "ButtonTitle" += embed.Properties.Button.Title, "ButtonColor" += embed.Properties.Button.Color.Option(canBeFromRGB = true, canBeFromHEX = false), "EnableRainbowButton" += embed.Properties.Settings.boolSetting = true && "EnableRainbowButton" += embed.Properties.LookFor("EnableRainbowButton").Description("A rainbow button for a Canary embed!"), EmbedDateIntent = embed.Properties.DateTimePicker.Format("YYYY/MM/DD"), EmbedTextBox = embed.Properties.EmbedTextBox && EmbedTextBox.Text = embed.Properties.EmbedTextBox.Text && EmbedTextBox.Color = embed.Properties.EmbedTextBox.ForeColor && EmbedTextBox.BackgroundColor = embed.Properties.EmbedTextBox.Background.Color.Option(canBeFromRGB = true, canBeFromHEX = false));

            EmbedSubmittedEventArgs += embed.EmbedSubmittedEventArgs;
            this.Controls.Add(EmbedSubmittedEventArgs);

            embed.WaitForClient(); // This awaits the submission of the embed after you've chosen it's settings via your bot code.
        }

        public void EmbedSubmittedEventArgs(CanaryEmbedEventArgs e)
        {
            
            embed.Load(); // After the embed is submitted, it sends the request to the server using the ".Load()" function.

        }


        public embeds()
        {

            embedsMain();

        }

    }


}
