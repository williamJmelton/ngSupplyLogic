import { Component, OnInit } from '@angular/core';
import {
  AngularFirestore,
  AngularFirestoreDocument,
  AngularFirestoreCollection,
} from "@angular/fire/firestore";

class Message {
  title: string;
  description: string;
  date: Date;
  constructor() {
    this.title = ''
    this.description = ''
    this.date = new Date();
  }
}


@Component({
  selector: 'app-send-messages',
  templateUrl: './send-messages.component.html',
  styleUrls: ['./send-messages.component.scss']
})
export class SendMessagesComponent implements OnInit {
  model: Message = new Message();
  newsCollection: AngularFirestoreCollection<Message> = this.fireStore.collection('news');

  constructor(private fireStore: AngularFirestore) { }

  ngOnInit() {
  }

  sendMessage(): void {
    console.log('form submitted: ', this.model);
    this.newsCollection.add({ ...this.model })
    this.model = new Message();
  }

}
