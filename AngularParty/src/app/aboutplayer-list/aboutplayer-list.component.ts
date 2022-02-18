import { Component, OnInit } from '@angular/core';
import { AboutPlayer } from '../models/aboutplayer';
import { AboutPlayerApiService } from '../services/about-player-api.service';

@Component({
  selector: 'aboutplayer-list',
  templateUrl: './aboutplayer-list.component.html',
  styleUrls: ['./aboutplayer-list.component.css']
})
export class AboutplayerListComponent implements OnInit {

  constructor(private apiService: AboutPlayerApiService) { }

  allAboutPlayer: AboutPlayer[]  = [];

  ngOnInit(): void {
    this.apiService.getAllAboutPlayers().then((aboutPlayerArray) =>
    {
      this.allAboutPlayer = aboutPlayerArray;
    })
  }

}
