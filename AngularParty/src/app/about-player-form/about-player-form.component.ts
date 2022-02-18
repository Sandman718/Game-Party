import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { AboutPlayer } from '../models/aboutplayer';
import { AboutPlayerApiService } from '../services/about-player-api.service';


@Component({
  selector: 'app-about-player-form',
  templateUrl: './about-player-form.component.html',
  styleUrls: ['./about-player-form.component.css']
})
export class AboutPlayerFormComponent implements OnInit {

  public getRandomInt() {
    return Math.floor(Math.random() * 10000);   
  }
  userid = this.getRandomInt();
  constructor(private aboutPlayerApi: AboutPlayerApiService) { }

  aboutPlayer: AboutPlayer = {
    id: this.userid,
    gameLibrary: '',
    favoriteGames: '',
    gamesWon: 0,
    gamesLost: 0
    
  }
  displayFormSubmitError: boolean = false;

  

  processForm(newAboutPlayerForm: NgForm){
    console.log("form created", newAboutPlayerForm, this.aboutPlayer);
    if(newAboutPlayerForm.form.status == 'VALID')
    {
      this.aboutPlayerApi.createNewAboutPlayer(this.aboutPlayer).then((test) =>
      {
        console.log(test);
      })
    }
    else
    {
      this.displayFormSubmitError = true;
    }
  }
  ngOnInit(): void {
  }

}
