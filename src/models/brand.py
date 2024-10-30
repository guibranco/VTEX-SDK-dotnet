from database import db

class Brand(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(80), nullable=False)
    description = db.Column(db.String(200))

    def to_dict(self):
        return {
            'id': self.id,
            'name': self.name,
            'description': self.description
        }

    def save(self):
        db.session.add(self)
        db.session.commit()

    def update(self, **kwargs):
        for key, value in kwargs.items():
            setattr(self, key, value)
        db.session.commit()

    def delete(self):
        db.session.delete(self)
        db.session.commit()
