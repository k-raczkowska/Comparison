package chain.requests;

import java.util.Date;

/**
 * Created by Karolina_2 on 2015-04-01.
 */
public class TransferRequest extends Request {

    public TransferRequest(String nazwa, Date date){
        this.nazwa = nazwa;
        this.date = date;
    }
}
