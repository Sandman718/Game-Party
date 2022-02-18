import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AboutplayerListComponent } from './aboutplayer-list.component';

describe('AboutplayerListComponent', () => {
  let component: AboutplayerListComponent;
  let fixture: ComponentFixture<AboutplayerListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AboutplayerListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AboutplayerListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
