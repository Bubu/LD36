from bottle import get, post, run, request, response
import shelve

@get('/plans/')
def get_plans():
    with shelve.open('db') as d:
        if not "plans" in d:
            d["plans"] = []
        return {'plans': d["plans"]}

@get('/plans')
def get_plans():
    with shelve.open('db') as d:
        if not "plans" in d:
            d["plans"] = []
        return {'plans': list(range(len(d["plans"])))}

@get('/plans/<id:int>')
def get_plan(id):
    assert isinstance(id, int)
    with shelve.open('db') as d:
        if not "plans" in d:
            d["plans"] = []
        if id < len(d["plans"]):
            return d["plans"][id]
        else:
            response.status = 404
            return {'error': 'Not found!'}

@post('/plans')
def post_plan():
    with shelve.open('db') as d:
        if not "plans" in d:
            d["plans"] = []
        plans = d["plans"]
        plans.append(request.json)
        d["plans"] = plans
    return {'id': len(plans)-1}

run(host='localhost', port=8080, debug=True)
