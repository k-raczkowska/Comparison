package chain.requests;

import java.util.Date;

/**
 * Created by Karolina_2 on 2015-04-01.
 */
public class PersonalTrainingRequest extends Request {

    public PersonalTrainingRequest(String nazwa, Date date){
        this.date = date;
        this.nazwa = nazwa;
    }
}
